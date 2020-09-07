using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hublsoft.Monitor.Tests
{
    public class Tests
    {
        private HublSoftDbContext _context;
        
        [SetUp]
        public void Setup()
        {
            _context = CreateContext();
        }

        [Test]
        public void Action_RecordLogin_Valid_Success()
        {
            Action.RecordLogin(_context, "ben@orgabu.com", DateTime.Now);

            var count = _context.UserLogins.Count();

            Assert.IsTrue(count > 0);
        }

        [Test]
        [TestCase("user1", 5)]
        [TestCase("user2", 1)]
        [TestCase("user3", 3)]
        [TestCase("user4", 1)]
        [TestCase("user5", 2)]
        public void Action_GetLoginsForUser(string userId, int howMany)
        {
            SeedData();
            var result = Action.GetLoginsForUser(_context, userId);

            Assert.AreEqual(result.Count(), howMany);
        }

        [Test]
        [TestCase(90, 30, 1)]
        [TestCase(126, 1, 7)]
        [TestCase(400, 15, 6)]
        public void Action_GetLoginsForAllUsers(int start, int end, int expected)
        {
            SeedData();
            var result = Action.GetLoginsForAllUsers(_context, DateTime.Now.AddHours(-start), DateTime.Now.AddHours(-end));

            Assert.AreEqual(result.Count(), expected);
        }

        private void SeedData() 
        {
            if (_context.UserLogins.Count() == 0)
            {
                _context.UserLogins.AddRange(TestData());
                _context.SaveChanges();
            }
        }

        private HublSoftDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<HublSoftDbContext>()
           .UseInMemoryDatabase(databaseName: "HublsoftDatabase").Options;

            var context = new HublSoftDbContext(options);
            
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
                new LoginMonitorModel (){UserId = "user1", TimeStamp = DateTime.Now.AddHours(-10)},
                new LoginMonitorModel (){UserId = "user2", TimeStamp = DateTime.Now.AddDays(-4)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddDays(-10)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddDays(-11)},
                new LoginMonitorModel (){UserId = "user3", TimeStamp = DateTime.Now.AddDays(-12)},
                new LoginMonitorModel (){UserId = "user4", TimeStamp = DateTime.Now.AddDays(-100)},
                new LoginMonitorModel (){UserId = "user5", TimeStamp = DateTime.Now.AddHours(-1)},
                new LoginMonitorModel (){UserId = "user5", TimeStamp = DateTime.Now.AddMinutes(-6)}
            };

            return data;
        }
    }
}