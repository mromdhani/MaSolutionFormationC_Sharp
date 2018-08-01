
using BankingApp.L0.Domain;
using System.Collections.Generic;

namespace BankingApp.L1.DataAccess.Facade
{
    public interface IComptesRepository
    {

        // CRUD
        void OuvrirCompte(Compte c);  // C du CRUD
        Compte FindById(string id);   // R du CRUD
        IEnumerable<Compte> FindAll();  // Un autre R
        void Update(Compte c);  // U
        void Delete(string id);
        
    }
}
