using System;
using System.Collections.Generic;
using FactotumModels;

namespace FactotumAPI.Repository
{
    public class FakeMessages
    {
        public FakeMessages()
        {
        }

        public static IEnumerable<MMessage> GetMessages()
        {
            var m1 = new MMessage() { Id = 1, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 10, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m2 = new MMessage() { Id = 2, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 100, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m3 = new MMessage() { Id = 3, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 102, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m4 = new MMessage() { Id = 4, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 50, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m5 = new MMessage() { Id = 5, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 0, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m6 = new MMessage() { Id = 6, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 0, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m7 = new MMessage() { Id = 7, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 1, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m8 = new MMessage() { Id = 8, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 1, Description = "", Date = DateTime.UtcNow, Removed = false };
            var m9 = new MMessage() { Id = 9, Title = "Again fully shit on boards!", Link = "http://delfi.lv/", Rating = 1, Description = "", Date = DateTime.UtcNow, Removed = false };

            return new MMessage[] { m1, m2, m3, m4, m5, m6, m7, m8, m9 };
        }
    }
}
