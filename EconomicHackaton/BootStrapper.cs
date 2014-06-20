using EconomicHackaton.Core.Services;
using EconomicHackaton.ViewModels;
using MicroIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EconomicHackaton
{
    public static class BootStrapper
    {
        public static void Init(IMicroIocContainer container)
        { 
            // Load Services
            container.Register<IEconomy, Economy>(null, true);

            // Load ViewMoodel
            container.Register<MainPageViewModel, MainPageViewModel>(null, false);
        }
    }
}
