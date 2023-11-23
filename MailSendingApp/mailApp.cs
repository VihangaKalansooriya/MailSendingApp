using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.Data;
using System.Diagnostics;
using System.Transactions;
using Newtonsoft.Json;
using MailSendingApp;
using System.Text.Json.Serialization;
using System.Windows.Forms;

public class mailApp
{

    public async Task ProcessEmailAsync(string recipientEmail, int id)
    {
        try
        {
            SmtpClient smtpClient = new SmtpClient("smtp.office365.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(Globalconfig.SenderEmail, Globalconfig.SenderPassword)
            }; 

            Dictionary<string, object> argsval = new Dictionary<string, object>();

            using (SqlConnection dbConnection = new SqlConnection(Globalconfig.ConnectionString))
            {
                dbConnection.Open();
                string query = "SELECT TB_TYPE, TB_RUNNO FROM TB_MAILDETAILS WHERE TB_ID = @ID";

                using (SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            argsval.Add("reportName", "transaction");
                            argsval.Add("userType", "ADMIN");
                            argsval.Add("code", reader["TB_RUNNO"].ToString());
                            argsval.Add("menuCode", reader["TB_TYPE"].ToString());
                            argsval.Add("db", Globalconfig.databasename);
                        }
                    }
                }
            }
            MailMessage mail = new MailMessage(Globalconfig.SenderEmail, recipientEmail)
            {
                Subject = $"{argsval["menuCode"]} Report",
                Body = $"Dear Sir/Madam,\nThis email contains a {argsval["menuCode"]} PDF attachment for ID {id}\nThank You."
            };

            var startInfo = new ProcessStartInfo
            {
                FileName = $"E:\\ReportGen\\ReportGenerator.exe",
                Arguments = JsonConvert.SerializeObject(JsonConvert.SerializeObject(argsval)),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                try
                {
                    process.Start();
                    process.WaitForExit();
                }
                catch(Exception ex)
                {
                    Logger.LogError("Error running ReportGenerator.exe", ex);
                }
                
                var output = await process.StandardOutput.ReadToEndAsync();
                string resultString = output.Replace("\r", "").Replace("\n", "");
                Logger.LogInformation("Generated File Name: " + resultString);
                string pdfFullPath = $"E:\\GeneratedFiles\\{resultString}.pdf";
                Attachment attachment = new Attachment(pdfFullPath, MediaTypeNames.Application.Pdf);
                mail.Attachments.Add(attachment);
                await smtpClient.SendMailAsync(mail);
                UpdateStatus(id);
                Logger.LogInformation("Email sent ID: "+id+" and update status 1");
                MessageBox.Show("Email sent successfully.ID NO: "+id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
        catch (Exception ex)
        {
            Logger.LogError("Error attaching or sending email", ex); 
        }

    }

    static void UpdateStatus(int id)
    {
        string updateQuery = "UPDATE TB_MAILDETAILS SET TB_STATUS = 1 WHERE TB_ID = @ID";
        
        using (SqlConnection con = new SqlConnection(Globalconfig.ConnectionString))
        {
            using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
            {
                con.Open();
                updateCommand.Parameters.AddWithValue("@ID", id);
                updateCommand.ExecuteNonQuery();
                con.Close();
            }
        }
    }  

}
