using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInter
{
    internal class LaserJet : IPrinter
    {
        public void Speak(PrinterWindows printerWindows)
        {
            Console.WriteLine("LaserJet printer printing....");
            Console.WriteLine("LaserJet display dimension : 10*11");
        }
    }
}
