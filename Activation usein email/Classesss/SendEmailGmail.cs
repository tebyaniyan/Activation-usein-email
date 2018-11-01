using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SendMail
{
    public class SendEmailGmail
    {
        public static void Send(string To,string Subject,string Body)
        {
            var mail = new MailMessage();
            var smtpServer = new SmtpClient("SiteNameAdress");
            mail.From = new MailAddress("Email", "Subject");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = false;
           

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

           // smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("EmailName", "Password");
            //smtpServer.EnableSsl = true;

            smtpServer.Send(mail);

        }
    }
}