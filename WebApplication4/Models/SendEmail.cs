using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DAL;

namespace WebApplication4.Models
{
    public class SendEmail : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            db db = new db();
            var qservice = db.tanzimatEmails.FirstOrDefault();

            using (var message = new MailMessage())
            {
                message.To.Add(new MailAddress(email, "خریدار محترم"));
                message.From = new MailAddress("amirakbarii.ir10@gmail.com", "امیرمهدی اکبری");
                message.Subject = subject;
                message.Body = htmlMessage;
                message.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("amirakbarii.ir10@gmail.com", "amir.mkhz.akbari10");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }


            return Task.FromResult(0);
        }

    }
}
