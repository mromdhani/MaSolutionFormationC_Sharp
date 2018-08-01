using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODDO.Domain
{
   public  class Compte
    {
        public string Numero { get; set; }  // Auto-implemented properties (C#3)
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }

        public void Débiter(decimal montant)
        {
            Solde -= montant;
        }
        public void Créditer(decimal montant)
        {
            Solde += montant;
        }

        public override string ToString()
        {
                 return "Compte : ["+Numero+ " - "+ Proprietaire+ " - "+ Solde+ " ]";
        }

        // override object.Equals
        public override bool Equals(object obj)
        {          
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Compte converti = obj as Compte;


            return Numero.Equals(converti.Numero) &&
                   Proprietaire.Equals(converti.Proprietaire) &&
                   Solde.Equals(converti.Solde);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return Numero.GetHashCode();
        }
    }
}
