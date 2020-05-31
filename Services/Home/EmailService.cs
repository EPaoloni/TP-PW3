using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace Services.Home
{
    public class EmailService
    {
        public void Enviar(string destino, string token)
        {

            MailMessage email = new MailMessage();

            email.To.Add(new MailAddress(destino));
            email.From = new MailAddress("info@ayudando.com.ar");
            email.Subject = "Ayudando - Activacion de cuenta ";
            email.Body = "<h2>Activacion</h2>." +
                         "<p>Tu perfil ha sido creado con la dirección de e-mail. Para activarlo solo tienes que confirmar en el siguiente enlace:</p>" +
                         "<a href='http://" + HttpContext.Current.Request.Url.Authority + "/Home/Activar?token=" + token + "'> Activar </a>";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.SubjectEncoding = Encoding.UTF8;
            email.BodyEncoding = Encoding.UTF8;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "localhost";
            smtp.Port = 587;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("info@ayudando.com.ar", "infoayudando");

            try
            {
                smtp.Send(email);
            }
            catch (Exception ex)
            {       
                throw new Exception(ex.Message);
            }

        }

    }
}
