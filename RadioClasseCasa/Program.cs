using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioClasseCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio r = new Radio();
            r.Volume = float.Parse(Console.ReadLine());

            Console.WriteLine("Volume aumentato del 10/100:{0}, Volume diminuito del 10/100:{1}", r.Aumentav(), r.Diminuisciv());

            Console.ReadLine();
        }
    }
}
