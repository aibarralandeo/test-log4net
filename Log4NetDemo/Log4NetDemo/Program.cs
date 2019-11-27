using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4NetDemo
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintenance: water pump turn on");
            log.Warn("Maintenance: water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                //log.Error("We tried to divide by zero again", ex);
                log.Error("We tried to divide by zero again");
            }

            Counter j = new Counter();
            log4net.GlobalContext.Properties["Counter"] = j;

            for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
            {
                log.Fatal("This is a fatal error in the process");
            }

            //log.Fatal("Maintenance: water pump exploded");

            Console.ReadLine();
        }
    }
}
