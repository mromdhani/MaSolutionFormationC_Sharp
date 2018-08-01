using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class DemoLINQ
    {
        static void Main(string[] args)
        {

            var particiants =
                new List<string> {
                    "Mohamed Amine", "Khalil",
                    "Abdessalem", "Othman", "Oussama", "Ahmed"};


            var filtres_extension_style = 
                particiants.Where(p => p.StartsWith("A"));

            var filtres_query_style =
                    from p in particiants
                    where p.StartsWith("A")
                    select new { Nom = p, Entrepise = "ODDO Bank" } ;

            //// var vs dynamic
            ////var i = 111;

            //var i = 111;

            //string st;
            ////st.con
            
            //dynamic val;

            //val = 2222;
            //val++;
            //val = "Bon";

           



        }
    }
}
