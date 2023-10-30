using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianHolidays.Models
{
	public class Province
	{
        public int Id { get; set; }
        public string nameEn { get; set; }
        public string nameFr { get; set; }
        public string sourceLink { get; set; }
        public string sourceEn { get; set; }
    }
}

