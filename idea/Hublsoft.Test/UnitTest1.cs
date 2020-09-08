using Hublsoft.Web.Data;
using Hublsoft.Web.Infrastructure;
using Hublsoft.Web.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hublsoft.Test
{
    public class Tests
    {
        private ApplicationDbContext _context;
        private LoginService _service;
        [SetUp]
        public void Setup()
        {
            _context = CreateContext();
            _service = new LoginService(_context);
            SeedData();
        }
             
        [Test]
        [TestCase("user1", 3, 1, 4)]
        [TestCase("user2", 2, 2, 1)]
        [TestCase("user3", 1, 3, 2)]
        public void LoginService_GetCountFilteredLoginsForUser(string userId, int count, int granularity, int expected)
        {
            var result = _service.GetCountFilteredLoginsForUser(userId, count, (DataHelper.TimeSpanGranularity)granularity);

            Assert.AreEqual(result, expected);
        }

        private void SeedData()
        {
            if (_context.UserLoginMonitors.Count() == 0)
            {
                _context.UserLoginMonitors.AddRange(TestData());
                _context.SaveChanges();
            }
        }

        private ApplicationDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "HublsoftDatabase").Options;

            var context = new ApplicationDbContext(options);

            return context;
        }

        private List<LoginMonitorModel> TestData()
        {
            var data = new List<LoginMonitorModel>()
            {
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddDays(-1)},
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddHours(-1)},
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddHours(-4)},
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddHours(-36)},
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddYears(-10)},
                new LoginMonitorModel (){UserId = "user2", TimeStamp = DateTime.Now.AddDays(-4)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddDays(-10)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddDays(-11)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddMonths(-12)},
                new LoginMonitorModel (){UserId = "user4", TimeStamp = DateTime.Now.AddDays(-100)},
                new LoginMonitorModel (){UserId = "user5", TimeStamp = DateTime.Now.AddHours(-1)},
                new LoginMonitorModel (){UserId = "user5", TimeStamp = DateTime.Now.AddMinutes(-6)}
            };

            return data;
        }
    }
}