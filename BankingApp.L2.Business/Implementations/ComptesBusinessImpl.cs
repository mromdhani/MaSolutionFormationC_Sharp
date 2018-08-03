
using BankingApp.L1.DataAccess.Facade;
using BankingApp.L1.DataAccess.Implementations;
using BankingApp.L2.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L2.Business.Implementations
{
    public class ComptesBusinessImpl : IComptesBusiness
    {
        public const decimal TAUX = 0.1M;

        private IComptesRepository repo;//= new ComptesRepositoryImpl_EF();

        public ComptesBusinessImpl(IComptesRepository repo)
        {
            this.repo = repo;
        }

        public decimal ConsulterSolde(string id)
        {
            var resultat = repo.FindById(id);
            if (resultat != null)
            {
                // Supposons qu'une règle métier stipule que
                // les comptes commençeant par un "E" sont des
                // comptes épargnes et que le taux d'épargne est de 10%;
                return (resultat.Numero.StartsWith("E")) ?
                    resultat.Solde * (1 + TAUX)
                    :
                    resultat.Solde;
            }
            else
                return decimal.MinValue;

        }
       
    }
}
