using System;
using System.Net;
using System.Net.Mail;

namespace Sesion
{
    class EnviarMail
    {
        public static void SendCustomMail(string toEmail, string subject, string htmlBody)
        {
            string fromEmail = "skywayturismos@gmail.com";
            string displayName = "Recuperación de Cuenta";

            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(fromEmail, displayName),
                    Subject = subject,
                    Body = htmlBody,
                    IsBodyHtml = true
                };
                mail.To.Add(toEmail);

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(fromEmail, "nonl aqot gdjz vzdr"),
                    EnableSsl = true
                };

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR AL ENVIAR EL MENSAJE.\n\n" +
                    $"Detalles técnicos: {ex.Message}");
            }
        }
    }
}