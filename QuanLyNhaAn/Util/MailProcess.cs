using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaAn.Util
{
    internal class MailProcess
    {
        public readonly string FROM = "auto99sr@gmail.com";
        public readonly string PASS = "xxlrtxqimhfkyzgb";//Auto99Password
        public async Task<bool> sendMail(string to, string title, string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.Body = content;
                mail.IsBodyHtml = true;
                mail.From = new MailAddress(FROM);
                mail.Subject = title;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(FROM, PASS);
                   await smtp.SendMailAsync(mail);
                }

                return true;
            }
            catch (Exception e)
            {
                // Consider logging the exception here
                return false;
            }
        }

    }
}
