﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace IFSPMaker.Apresentacao
{
    public class Email
    {
        public void NewHeadlessEmail(string fromEmail, string password, string toAddress, string subject, string body)
        {
            using (System.Net.Mail.MailMessage myMail = new System.Net.Mail.MailMessage())
            {
                myMail.From = new MailAddress(fromEmail);
                myMail.To.Add(toAddress);
                myMail.Subject = subject;
                myMail.IsBodyHtml = true;
                myMail.Body = body;
               

                using (System.Net.Mail.SmtpClient s = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    s.DeliveryMethod = SmtpDeliveryMethod.Network;
                    s.UseDefaultCredentials = false;
                    s.EnableSsl = true;
                    s.DeliveryMethod = SmtpDeliveryMethod.Network;
                    s.UseDefaultCredentials = false;
                    s.Credentials = new System.Net.NetworkCredential(myMail.From.ToString(), password);
                    s.EnableSsl = true;
                    s.Send(myMail);
                    
                }
            }
        }
    }
}
