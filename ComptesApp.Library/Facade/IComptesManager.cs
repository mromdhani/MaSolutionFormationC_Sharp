using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Facade
{
    public interface IComptesManager
    {

        // CRUD
        void OuvrirCompte(Compte c);  // C du CRUD
        Compte FindById(string id);   // R du CRUD
        IEnumerable<Compte> FindAll();  // Un autre R
        void Update(Compte c);  // U
        void Delete(string id);
        
    }
}
