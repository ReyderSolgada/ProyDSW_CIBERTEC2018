using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;

namespace Dominio.MainModule
{
    public class EnviarCorreo
    {
        Boolean estado = true;
        String merror;

        public EnviarCorreo(string destinatario, string asunto, string mensaje)
        {
            MailMessage correo = new MailMessage();
            SmtpClient protocolo = new SmtpClient();

            correo.To.Add(destinatario);
            correo.From = new MailAddress("gallardoj515@gmail.com", "Empresa Gallardo");
            correo.Subject = asunto;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.Body = mensaje;
            correo.BodyEncoding = System.Text.Encoding.UTF8; ;
            correo.IsBodyHtml = false;

            protocolo.Credentials = new System.Net.NetworkCredential("gallardoj515@gmail.com", "14dejulio");
            protocolo.Port = 587;
            protocolo.Host = "smtp.gmail.com";
            protocolo.EnableSsl = true;

            try
            {
                protocolo.Send(correo);
            }
            catch (SmtpException error)
            {
                estado = false;
                merror = error.Message.ToString();
            }
        }

            public Boolean Estado
            {
                get { return estado; }
            }

            public String mensaje_error
            {
                get { return merror; }
            }

        }

    }
