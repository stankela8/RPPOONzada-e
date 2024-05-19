using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrasciStvaranja_4._DZ
{
    public class Prvi
    {

        /* RADI SE O OBRASCU STVARANJA GRADITELJ. */
        public interface IMailConstructor
        {
            IMailConstructor AddSubject(string subject);
            IMailConstructor AddContent(string content);
            IMailConstructor AddRecipient(string recipient);
            IMailConstructor AddAttachments(string attachments);
            Mail Construct();
        }
        public class Mail
        {
            public string Subject { get; set; }
            public string Content { get; set; }
            public string Recipient { get; set; }
            public string Attachments { get; set; }
        }
        public class MailConstructor : IMailConstructor
        {
            private Mail mail;

            public MailConstructor()
            {
                mail = new Mail();
            }

            public IMailConstructor AddSubject(string subject)
            {
                mail.Subject = subject;
                return this;
            }

            public IMailConstructor AddContent(string content)
            {
                mail.Content = content;
                return this;
            }

            public IMailConstructor AddRecipient(string recipient)
            {
                mail.Recipient = recipient;
                return this;
            }

            public IMailConstructor AddAttachments(string attachments)
            {
                mail.Attachments = attachments;
                return this;
            }

            public Mail Construct()
            {
                return mail;
            }
        }
        public class SMTP
        {
            private IMailConstructor mailConstructor;

            public SMTP(IMailConstructor mailConstructor)
            {
                this.mailConstructor = mailConstructor;
            }

            public void SendNoReplyMail()
            {
                Mail mail = mailConstructor
                    .AddSubject("No Reply")
                    .AddContent("Hello World")
                    .Construct();

                // Logika za slanje maila
                Console.WriteLine($"Sending Mail: \nSubject: {mail.Subject}\nContent: {mail.Content}");
            }
        }

    }
}
