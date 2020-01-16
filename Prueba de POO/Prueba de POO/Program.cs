using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var singleton3 = Singleton.GetInstance();
            var singleton4 = Singleton.GetInstance();
            singleton1.Name = "Sample 1";
            singleton2.Name = "Sample 2";
            singleton3.Name = "Sample 3";
            singleton4.Name = "Sample 4";
            Console.WriteLine("Objeto 1: " + singleton1.Name);
            Console.WriteLine("Objeto 2: " + singleton2.Name);
            Console.WriteLine("Objeto 3: " + singleton3.Name);
            Console.WriteLine("Objeto 4: " + singleton4.Name);
            Console.ReadLine();
        }
    }
}
