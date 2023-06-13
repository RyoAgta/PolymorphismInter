using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInter
{
    public class Canon : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("Canon printer printing....");
            Console.WriteLine("Canon display dimension : 10*11");
        }
    }
}
