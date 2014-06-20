using EconomicHackaton.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EconomicHackaton
{
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();
        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}
