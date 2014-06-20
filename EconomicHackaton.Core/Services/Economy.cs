using EconomicHackaton.Core.DataParse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace EconomicHackaton.Core.Services
{
    public class Economy : IEconomy
    {
        #region members
        private string url = "http://radityalabs.net/sunnah/list_sunnah.php";

        HttpClient httpClient = new HttpClient();
        #endregion
        
        
        public async void GetDataKeuangan(Action<EconomyDataParse, Exception> callback)
        {
            try
            {
                HttpResponseMessage respone = await httpClient.GetAsync(url);
                respone.EnsureSuccessStatusCode();
                string responBody = await respone.Content.ReadAsStringAsync();

                EconomyDataParse content = JsonConvert.DeserializeObject<EconomyDataParse>(responBody);
                callback.Invoke(content, new Exception());
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine("======== Exception Caught! ========");
                Debug.WriteLine("======== Message :{0} ", ex.Message + " ========");
            }
            httpClient.Dispose();
        }
    }
}
