using System;
using System.Threading.Tasks;
using WaybackMachine.DotNet.Client.Models;

namespace ElectricityMap
{
    public class ElectricityMapClient : IElectricityMapClient
    {
        public async Task<Zones> GetZonesAsync() 
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(url);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Snapshot snapshot = JsonConvert.DeserializeObject<Snapshot>(responseString);
            
            return snapshot;
        }
    }
}