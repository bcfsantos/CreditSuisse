using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Domain
{
    public class Highrisk
    {
        private readonly ITrade<Highrisk> _trade;
        public Highrisk(ITrade<Highrisk> trade)
        {
            _trade = trade;
        }
        public string isHighrisk(ITrade<Highrisk> trade)
        {
            var isHighrisk = trade.Value > 1000 && trade.ClientSector == Sector.Private.ToString();
            return isHighrisk ? trade.GetCategory(this) : String.Empty;
        }
    }
}
