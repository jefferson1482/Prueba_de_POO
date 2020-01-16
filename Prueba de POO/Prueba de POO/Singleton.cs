using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_POO
{
    public class Singleton
    {
        
        //Creamos el objeto Nombre
        public string Nombre { get; set; }
        private Singleton()
        {

        }
        //static es para que el  elemento quede en memoria para que no los elimine
        private static Singleton singleton;

        public static Singleton GetInstance()
        {

            if (singleton == null)
            {
                //Es para no instanciar en el program, directamente se realiza aqui 
                singleton = new Singleton();

            }

            return singleton;

        }
    }
}
