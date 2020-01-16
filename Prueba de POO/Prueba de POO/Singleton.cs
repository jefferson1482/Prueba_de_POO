using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_POO
{
    public class Singleton
    {
        // Variable estática para la instancia, se necesita utilizar una función lambda ya que el constructor es privado
        //static es para que el  elemento quede en memoria para que no lo elimine
        public string Name { get; set}
        private Singleton()
        {

        }

        private static Singleton _singleton;

        public static Singleton GetInstance()
        {

            if (_singleton == null)
            {

                _singleton = new Singleton();

            }

            return _singleton;

        }
    }
}
