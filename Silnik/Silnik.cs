using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnik
{
    public class Silnik
    {
        public bool CzyWlaczony;
        public int moc;

        public void ZwiekszMoc(int wartosc)
        {
            moc = moc + wartosc;
        }

        public void WlaczSilnik()
        {
            CzyWlaczony = true;
            Console.WriteLine("Silnik włączony");
        }

        public void Info()
        {
            Console.WriteLine($"{moc} i {CzyWlaczony}");
        }
    }
}
