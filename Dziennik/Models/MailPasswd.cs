﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dziennik.Models
{
    public class MailPasswd
    {
        private String smtpEmailAdress = "dziennikMVC@outlook.com";
        public String SmtpEmailAdress { get { return smtpEmailAdress; } }

        private String emailSubject = "Dziennik - nowe hasło";
        public String EmailSubject { get { return emailSubject; } }

        private String smtpHost = "smtp.office365.com";
        public String SmtpHost { get { return smtpHost; } }

        private int smtpPort = 587;
        public int SmtpPort { get { return smtpPort; } }

        public String EmailBody { get { return emailBody; } }
        private String emailBody = File.ReadAllText("wwwroot/mail_body_psswd.html");
    }
}
