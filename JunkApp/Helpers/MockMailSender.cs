﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkApp.Helpers
{
    public class MockMailSender : IMailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}
