using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireTaskScheduler
{
    public class PrintJob : IPrintJob
    {

        public void Print()
        {
            Console.WriteLine($"Hanfire recurring job!");
        }
    }
}
