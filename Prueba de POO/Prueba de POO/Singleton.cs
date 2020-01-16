using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_POO
{
    public class Singleton
    {
        
        public string Name { get; set; }
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
