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
            email.From = new MailAddress("apfundacion@outlook.com.ar");
            email.Subject = "PW3TP - Activacion de cuenta ";
            email.Body = "<h2>Activacion</h2>." +
                         "<p>Tu perfil ha sido creado con la dirección de e-mail. Para activarlo solo tienes que confirmar en el siguiente enlace:</p>" +
                         "<a href='http://" + HttpContext.Current.Request.Url.Authority + "/Home/Activar?token=" + token + "'> Activar </a>";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
            email.SubjectEncoding = System.Text.Encoding.UTF8;
            email.BodyEncoding = System.Text.Encoding.UTF8;

            SmtpClient smtp = new SmtpClient();

            smtp.Host = "smtp.office365.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("apfundacion@outlook.com.ar", "donacion2019");

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
