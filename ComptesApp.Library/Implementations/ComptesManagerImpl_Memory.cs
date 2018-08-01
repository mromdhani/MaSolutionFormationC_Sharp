using ComptesApp.Library.Facade;
using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Implementations
{
    public class ComptesManagerImpl_Memory : IComptesManager
    {

        private IList<Compte> data =
            new List<Compte> {
                 new Compte { Numero="C1000", Proprietaire="Zakaria", Solde=1000M},
                 new Compte { Numero="C2000", Proprietaire="Safouen", Solde=2000M},
                 new Compte { Numero="C3000", Proprietaire="Iheb", Solde=3000M}
            }; 

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Compte> FindAll()
        {
            return data;
        }

        public Compte FindById(string id)
        {
            return data.FirstOrDefault(c => c.Numero.Equals(id));
        }

        public void OuvrirCompte(Compte c)
        {
            throw new NotImplementedException();
        }

        public void Update(Compte c)
        {
            throw new NotImplementedException();
        }
    }
}
