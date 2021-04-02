using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication1
{
    public class Mail
    {
        private MailAddress sendAddress = null;
        private MailAddress toAddress = null;
        private string sendPassword = "qew164712486@";

        public Mail(string sendMail)
        {
            this.sendAddress = new MailAddress(sendMail);
        }
        public void SetToAddress(string toMail)
        {
            this.toAddress = new MailAddress(toMail);
        }
        public string SendEmail(string subject, string body)
        {
            SmtpClient smtp = null;
            MailMessage message = null;
            try
            {
                smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(sendAddress.Address, sendPassword),
                    Timeout = 20000
                };
                message = new MailMessage(sendAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };
                smtp.Send(message);
                return "send mail ok";
            }
            catch (Exception e)
            {
                return "send mail fail";
            }
            finally
            {
                if (smtp != null) { smtp.Dispose(); }
                if (message != null) { message.Dispose(); }
            }
        }
    }
}
