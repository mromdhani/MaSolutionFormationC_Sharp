﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L2.Business.Facade
{
   public interface IComptesBusiness
    {
        decimal ConsulterSolde(string id);
    }
}
