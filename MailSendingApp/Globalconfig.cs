﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSendingApp
{
    public static class Globalconfig
    {
        public static string ConnectionString { get; set; }
        public static string SenderEmail { get; set; }
        public static string SenderPassword { get; set; }
        public static string logfilepath { get; set; }
        public static string databasename { get; set; }
    }
}
