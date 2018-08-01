using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    //delegate void Operation(int x, int y); // Forme de délégation
   
        class Personne
    {
        public string Nom { get; set; }
    }
    class Program
    {
        
        static void permuter( ref Personne a,  ref Personne b)
        {
            var intermed = a;
            a = b;
            b = intermed;
        }


        static void Main(string[] args)
        {
            var p1 = new Personne {Nom="Mohamed" };
            var p2 = new Personne { Nom = "Ali" };
            permuter( ref p1, ref  p2);
            Console.WriteLine(p1.Nom + " - " +p2.Nom);


            string st = @"123";
            int resultat;
           if (! int.TryParse(st, out resultat))
                Console.WriteLine("Impossible");
           else
                Console.WriteLine(resultat);
           
            // OUT - CalculUtils.Multiplier(11, 22);

            // Subscription
            // Operation delegué1 = CalculUtils.Additionner;
            Action<int, int> delegué1 = CalculUtils.Additionner; 
            
            // Action & Func since C#4, 2010

            // Another subscription
            delegué1 += CalculUtils.Multiplier;


            // Another subscription using an anonymous delegate (C#2, 2005)
            //delegué1 += delegate (int a, int b)
            //{
            //    Console.WriteLine($"La soustraction de {a} et {b} est égale à :  {a - b}");

            //};
            delegué1 +=  ( a,  b)  =>      // Since C# 3, 2008
            {
                Console.WriteLine($"La soustraction de {a} et {b} est égale à :  {a - b}");

            };


            // Notification
            delegué1(11, 22);

            
        }

       
    }
}
