using ODDO.Domain;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic; // Since 2005, .NET 2.0


namespace ODDO.Clients.Console
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList ar = new ArrayList();
            ar.Add(123);
            ar.Add("Bonjour");
            ar.Add(DateTime.Now);


           // object

            int? jj;

            jj = null;

            IEnumerable<string> noms = new List<string>() { "Safouen", "Iheb"};
         //  noms.Add("Safouen");
           // noms.

           // var resultat = noms[0];



            System.Console.WriteLine("Bienvenue dans C#");


            float i = 10.6F;

            var c = new Compte{
                Numero="C1000", 
                Proprietaire="Zakaria", 
                Solde=1000M 
            };  // Object initializer, since C# 3

            System.Console.WriteLine(c);
      
        }
    }
}
