using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silnik s1 = new Silnik();
            s1.moc = 30;
            s1.CzyWlaczony = false;

            s1.Info();
            s1.ZwiekszMoc(100);

            s1.Info();

            Console.ReadLine();
        }
    }
}
