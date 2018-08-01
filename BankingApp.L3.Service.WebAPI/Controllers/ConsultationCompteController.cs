using BankingApp.L2.Business.Facade;
using BankingApp.L2.Business.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingApp.L3.Service.WebAPI.Controllers
{
    public class ConsultationCompteController : ApiController
    {
        private IComptesBusiness business =
               new ComptesBusinessImpl();

        // GET api/values
        public decimal Get(string numero)
        {
            return business.ConsulterSolde(numero);
        }


    }
}
