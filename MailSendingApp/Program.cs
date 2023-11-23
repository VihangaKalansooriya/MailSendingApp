using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.Configuration;
using Serilog;


namespace MailSendingApp
{
    internal static class Program
    {
       
        [STAThread]
        static async Task Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json").Build();

            Globalconfig.ConnectionString = config.GetConnectionString("DefaultConnection");
            Globalconfig.SenderEmail = config.GetSection("EmailConfiguration")["SenderEmail"];
            Globalconfig.SenderPassword = config.GetSection("EmailConfiguration")["SenderPassword"];
            Globalconfig.logfilepath = config.GetSection("LogfilePath")["logfilepath"];
            Globalconfig.databasename = config.GetSection("DatabaseConfiguration")["databasename"];

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(Globalconfig.logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Task.Run(() => DeleteLogFileAfterOneWeek());

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form3());
                Application.Run(new Form2());
            }
            catch(Exception ex)
            {
                Logger.LogError("Error in Program.cs :", ex);
            }  
        }
        private static async Task DeleteLogFileAfterOneWeek()
        {
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), Globalconfig.logfilepath);

            try
            {
                while (true)
                {
                    await Task.Delay(TimeSpan.FromDays(1));

                    if (File.Exists(Globalconfig.logfilepath))
                    {
                        DateTime creationTime = File.GetCreationTime(Globalconfig.logfilepath);
                        DateTime oneWeekAgo = DateTime.Now.AddDays(-7);

                        if (creationTime < oneWeekAgo)
                        {
                            File.Delete(Globalconfig.logfilepath);
                            Log.Information("Log file deleted successfully.");
                        }
                        else
                        {
                            Log.Information("Log file is not old enough to delete.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error deleting log file: {ex.Message}");
            }
        }

    }
}
