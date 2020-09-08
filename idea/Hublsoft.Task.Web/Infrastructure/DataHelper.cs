using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hublsoft.Web.Infrastructure
{
    public static class DataHelper
    {
        public enum TimeSpanGranularity
        {
            Days = 1,
            Months = 2,
            Years = 3
        }
        public static DateTime DefineBeginDate(int count, TimeSpanGranularity granularity)
        {
            var beginDate = DateTime.MinValue;
            switch (granularity)
            {
                case DataHelper.TimeSpanGranularity.Days:
                    beginDate = DateTime.Now.AddDays(-count);
                    break;
                case DataHelper.TimeSpanGranularity.Months:
                    beginDate = DateTime.Now.AddMonths(-count);
                    break;
                case DataHelper.TimeSpanGranularity.Years:
                    beginDate = DateTime.Now.AddYears(-count);
                    break;
                default:
                    break;
            }
            return beginDate;
        }
    }
}
