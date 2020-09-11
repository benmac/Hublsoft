using Hublsoft.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hublsoft.Web.Models
{
    public class LoginMonitorVM 
    {
        public List<LoginMonitorModel> LoginData { get; set; }
        public DataHelper.TimeSpanGranularity Granularity { get; set; }
        public int GranularityCount { get; set; }
        public int ResultCount { get; set; }
    }
}
