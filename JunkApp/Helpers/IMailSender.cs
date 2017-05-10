using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkApp.Helpers
{
    public interface IMailSender
    {
        void Send(string toaddress, string subject);
    }
}
