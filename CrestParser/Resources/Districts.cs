using CrestParser.Helpers;
using CrestParser.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrestParser.Resources
{
    public class Districts
    {
        public async Task<List<District>> GetDistricts()
        {
            var httpClient = HttpClientExtensions.CreateGzipEnabledClient();
            var districtsJson = await httpClient.GetStringAsync("http://public-crest.eveonline.com/districts/");
            var rootObject = JsonConvert.DeserializeObject<DistrictRootObject>(districtsJson);

            return rootObject.Items;
        }
    }
}
