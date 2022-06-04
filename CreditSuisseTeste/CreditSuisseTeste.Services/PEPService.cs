using CreditSuisseTeste.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseTeste.Services
{
    public class PEPService : IPEPService
    {
        private readonly string _category = "PEP";
        private readonly ITrade _tradePEP;
        public PEPService(ITrade tradePEP)
        {
            _tradePEP = tradePEP;
        }
        public IList<string> isPEP(IList<string> listTradePEP)
        {
            var listPEP = new List<string>();

            foreach (var tradePEP in listTradePEP)
            {
                var trade = _tradePEP.GetTrade(tradePEP);
                if (trade.IsPoliticallyExposed)
                    listPEP.Add(_category);
            }
            return listPEP;


        }
    }
