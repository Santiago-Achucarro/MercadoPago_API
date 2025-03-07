using System;
using System.Net.Mail;

namespace KSKBE.Mail
{
    class EnviarMail
    {
        public string mailDestinatario { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }
        public string mailOrigen { get; set; }
        public string nombreOrigen { get; set; }
        public string servidorMail { get; set; }
        public int puerto { get; set; }
        public Boolean ssl { get; set; }
        public Boolean autenticacion { get; set; }
        public Boolean html { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string ruta { get; set; }
        public string archivo { get; set; }

        public bool mailEnviado { get; }
        public EnviarMail(string mailDestinatario, string asunto, string cuerpo,
            string mailOrigen, string nombreOrigen, string servidorMail,
            int puerto, Boolean ssl, Boolean autenticacion,
            Boolean html, string usuario, string contrasena)
        {
            this.mailDestinatario = mailDestinatario;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.mailOrigen = mailOrigen;
            this.nombreOrigen = nombreOrigen;
            this.servidorMail = servidorMail;
            this.puerto = puerto;
            this.ssl = ssl;
            this.autenticacion = autenticacion;
            this.html = html;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.mailEnviado = enviarEmail();
        }
        public EnviarMail(string mailDestinatario, string asunto, string cuerpo, bool html, string ruta = "", string  archivo ="")
        {


            this.mailDestinatario = mailDestinatario;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.html = html;
            this.ruta = ruta;
            this.archivo = archivo;

            //Leemos los datos que faltan (servidor, autenticación, email origen ...) del fichero de configuración
            LeerGuardarDatosConfiguracion fConf = new LeerGuardarDatosConfiguracion();
            //this.mailOrigen = fConf.leerValorConfiguracion("Email - Email origen");
            this.mailOrigen = "tesoreriaksk@kosiuko.com";
            this.nombreOrigen = "Sucursal Kosiuko";
            this.puerto = 587;
            this.servidorMail = "smtp.office365.com";
            this.ssl = true;
            this.autenticacion = true;
            
            this.usuario = "tesoreriaksk@kosiuko.com";
            CifrarDescifrarTexto cTexto = new CifrarDescifrarTexto();
            //            this.contrasena = cTexto.descifrarTextoAES(fConf.leerValorConfiguracion("Email - Contraseña"),
            //                "Encriptad0", "SalT", "MD5", 22, "River", 128);

            //this.contrasena = "obkblpfthsihebrm";
            this.contrasena = "tesoksk23@";

            this.mailEnviado = enviarEmail();

            /*
            <add key="SMTPServer" value="smtp.office365.com"/>
    		<add key="SMTPPassword" value="tesoksk23@"/>
	    	<add key="SMTPUser" value="tesoreriaksk@kosiuko.com"/>
		    <add key="SMTPPort" value="587"/>
		    <add key="SMTPUseSSL" value="1"/> 

             */

        }

        public EnviarMail()
        {
            this.mailEnviado = enviarEmail();
        }
        public bool enviarEmail()
        {
            string rutaArchivo = this.ruta + this.archivo;
            //string rutaArchivo = @"C:\PDFS\2023\08\F0010B00000052.pdf"; // Ruta completa del archivo
            Attachment attachment = new Attachment(rutaArchivo);
                        
            SmtpClient SmtpServer = new SmtpClient();
            try
            {
                
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(usuario, contrasena);
                SmtpServer.Port = puerto;
                SmtpServer.Host = servidorMail;
                SmtpServer.EnableSsl = ssl;
                MailMessage mail = new MailMessage(mailOrigen, mailDestinatario);
                //                mail.From = new MailAddress(mailOrigen);
                //mail.To.Add(new MailAddress(mailDestinatario));
                mail.Subject = asunto;
                mail.Body = cuerpo;

                mail.IsBodyHtml = html;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                //atachment
                
                mail.Attachments.Add(attachment);
                


                SmtpServer.Send(mail);
                new EscribirLog("Enviado email a " + mailDestinatario, true);
                return true;
            }
            catch (Exception error)
            {
                new EscribirLog("Error al enviar email a " + mailDestinatario + " " +
                        error.GetType().ToString() + " " + error.Message, true);
                return false;
            }
            finally
            {
                attachment.Dispose();
                SmtpServer.Dispose();
            }
        }
    }
}
