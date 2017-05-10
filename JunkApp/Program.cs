using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JunkApp.Helpers;
using Ninject;
using System.Reflection;

namespace JunkApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();

            var formHandler = new FormHandler(mailSender);
            formHandler.Handle("address2@domain.com");

            Console.ReadLine();          
        }
    }
}
