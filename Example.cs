using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEnum
{
    class Program
    {
       

        static void Main()
        {
            // ... An enum local variable.
            Importance value = Importance.Critical;
            
            //if fuertemente tipado.
            // ... Test against known Importance values.
            if (value == Importance.Trivial)
            {
                Console.WriteLine("Not true");
            }
            else if (value == Importance.Critical)
            {
                Console.WriteLine("True");
            }
        }
    }

}
