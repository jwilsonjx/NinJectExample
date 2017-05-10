using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkApp.Helpers
{
    public class FormHandler
    {
        private readonly IMailSender mailsender;
        public FormHandler(IMailSender mailSender)
        {
            this.mailsender = mailsender;
        }

        public void Handle(string toAdress)
        {
            IMailSender mailSender = new MockMailSender();
            mailSender.Send(toAdress, "This is non-Ninject exmaple");
        }
    }
}
