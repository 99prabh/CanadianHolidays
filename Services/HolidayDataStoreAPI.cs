using System;
using System.Dynamic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using CanadianHolidays.Services;
using CanadianHolidays.Model;

namespace CanadianHolidays.Services
{
    class HolidayDataStoreAPI : IHolidayDataStore<Holiday>
    {
        private static string API => "https://canada-holidays.ca/api/v1/holidays?year=2023";

        public async Task<IEnumerable<Holiday>> GetHolidayAsync()
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync($"{API}");

            var holiday = HolidayBuilder(json);

            return holiday;
        }

        private List<Holiday> HolidayBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<APIResponse>(json);

            return response.Holidays;
        }
    }
}

