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
            //Aquí creamos 4 objetos que pertenecen, en realidad, al mismo objeto: el objeto único
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var singleton3 = Singleton.GetInstance();
            var singleton4 = Singleton.GetInstance();
            singleton1.Nombre = "EJEMPLO 1";
            singleton2.Nombre = "EJEMPLO 2";
            singleton3.Nombre = "EJEMPLO 3";
            singleton4.Nombre = "EJEMPLO 4";
            Console.WriteLine("HOLA: " + singleton1.Nombre);
            Console.WriteLine("INGENIERO: " + singleton2.Nombre);
            Console.WriteLine("PANCHANA: " + singleton3.Nombre);
            Console.WriteLine("DE PARTAR DE JJVR: " + singleton4.Nombre);
            Console.ReadLine();
        }
    }
}
