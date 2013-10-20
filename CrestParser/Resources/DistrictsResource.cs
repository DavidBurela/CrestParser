using CrestParser.Helpers;
using CrestParser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrestParser.Resources
{
    public class DistrictsResource
    {
        public static async Task<List<District>> GetDistricts()
        {
            var httpClient = HttpClientExtensions.CreateGzipEnabledClient();
            var districtsJson = await httpClient.GetStringAsync("http://public-crest.eveonline.com/districts/");
            
            return ParseDistricts(districtsJson);
        }

        public static List<District> ParseDistricts(string districtsJson)
        {
            var rootObject = JsonConvert.DeserializeObject<DistrictRootObject>(districtsJson);

            return rootObject.Items;
        }
    }
}
