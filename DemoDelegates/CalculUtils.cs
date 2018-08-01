using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class CalculUtils
    {
       internal static void Additionner(int a, int b)
        {
            if (DateTime.Now.Date.Date.Day >=0)
            {
                Console.WriteLine($"La somme de {a} et {b} est égale à :  {a + b}"); 
            } else
            {
                int i = 10;
                i++;
            }
        }
       internal static void Multiplier(int a, int b)
        {
            Console.WriteLine($"Le produit de {a} et {b} est égal à : {a * b}");
        }
    }
}
