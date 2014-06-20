using EconomicHackaton.Core.DataParse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EconomicHackaton.Core.Services
{
    public interface IEconomy
    {
        void GetDataKeuangan(Action<EconomyDataParse, Exception> callback);
    }
}
