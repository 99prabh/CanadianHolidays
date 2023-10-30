using System;
using CanadianHolidays.Model;
using CanadianHolidays.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CanadianHolidays.Services
{
    interface IHolidayDataStore<Holiday>
    {
        Task<IEnumerable<Holiday>> GetHolidayAsync();

    }
}
