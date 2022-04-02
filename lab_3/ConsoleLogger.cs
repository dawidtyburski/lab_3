using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class ConsoleLogger : WriterLogger
    {

        public override void Log(params string[] messages)
        {
            writer = Console.Out;
            writer.Write("123");
            writer.Flush();
        }
        public override void Dispose()
        {
           
        }
    }
}
