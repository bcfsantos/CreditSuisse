using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseTeste.Services
{
    public   interface IPEPService
    {
        IList<string> isPEP(IList<string> listTradeHighRisk);
    }
}
