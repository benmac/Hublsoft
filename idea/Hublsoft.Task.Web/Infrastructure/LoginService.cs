using Hublsoft.Web.Data;
using Hublsoft.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Hublsoft.Web.Infrastructure.DataHelper;

namespace Hublsoft.Web.Infrastructure
{
    public class LoginService
    {
        public readonly ApplicationDbContext _context;
        public LoginService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void RecordLogin(string userId, DateTime timestamp)
        {
            var model = new LoginMonitorModel() { UserId = userId, TimeStamp = timestamp };

            _context.UserLoginMonitors.Add(model);
            _context.SaveChanges();
        }

        public List<LoginMonitorModel> GetLoginsForUser(string userId)
        {
            return _context.UserLoginMonitors.Where(x => x.UserId == userId).ToList();
        }

        public int GetCountFilteredLoginsForUser(string userId, int? count, TimeSpanGranularity granularity = 0)
        {
            if (count.HasValue && granularity > 0)
            {
                var beginDate = DefineBeginDate(count.Value, granularity);
                return _context.UserLoginMonitors.Where(x => x.UserId == userId && x.TimeStamp >= beginDate).Count();
            }
            else
            {
                return GetLoginsForUser(userId).Count();
            }
        }

        public List<LoginMonitorModel> GetLoginsForAllUsers()
        {
            return _context.UserLoginMonitors.ToList();
        }

        public List<LoginMonitorModel> GetLoginsForAllUsers(DateTime start, DateTime end)
        {
            return _context.UserLoginMonitors.Where(x => x.TimeStamp >= start && x.TimeStamp <= end).ToList();
        }
    }
}
