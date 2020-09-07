using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hublsoft.Monitor
{
    public static class Action
    {
        public static void RecordLogin(DbContext context, string userId, DateTime timestamp)
        {
            var model = new LoginMonitorModel() { UserId = userId, TimeStamp = timestamp };

            ((HublSoftDbContext)context).UserLogins.Add(model);
            context.SaveChanges();
        }

        public static List<LoginMonitorModel> GetLoginsForUser(HublSoftDbContext context, string userId)
        {
            return context.UserLogins.Where(x => x.UserId == userId).ToList();
        }

        public static List<LoginMonitorModel> GetLoginsForAllUsers(HublSoftDbContext context)
        {
            return context.UserLogins.ToList();
        }
        public static List<LoginMonitorModel> GetLoginsForAllUsers(HublSoftDbContext context, DateTime start, DateTime end)
        {
            return context.UserLogins.Where( x => x.TimeStamp >= start && x.TimeStamp <= end).ToList();
        }
    }
}
