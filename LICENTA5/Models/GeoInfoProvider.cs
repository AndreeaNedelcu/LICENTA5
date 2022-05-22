using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LICENTA5.Models.ViewModels;
using Newtonsoft.Json;

namespace LICENTA5.Models
{
    public class GeoInfoProvider
    {

        private readonly HttpClient _httpClient;
        //create constructor and call HttpClient
        public GeoInfoProvider()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5)
            };
        }
        public async Task<string> GetIPAddress()
        {

            var ipAddress = await _httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAddress.IsSuccessStatusCode)
            {
                var json = await ipAddress.Content.ReadAsStringAsync();
                return json.ToString();
            }
            return "";
        }

        public async Task<string> GetGeoInfo()
        {
            //I have already created this function under GeoInfoProvider class.
            var ipAddress = await GetIPAddress();
            // When geting ipaddress, call this function and pass ipaddress as given below
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=181601ebb5b10caa7cac2b391e8a23e7");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var model = new GeoInfoViewModel();
                model = JsonConvert.DeserializeObject<GeoInfoViewModel>(json);
                
            }
            return null;
        }
    }
}
