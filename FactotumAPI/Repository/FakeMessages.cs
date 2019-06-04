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

        public static IEnumerable<MDashBoardFact> GetDashBoardFacts()
        {

                    //public int FactId { get; set; }

        //public String FactTitle { get; set; }
        //public String FactHashTags { get; set; }
        //public String FactLink { get; set; }
        //public DateTime FactCreateDate { get; set; }
        //public int FactRating { get; set; }
        var m1 = new MDashBoardFact() {
            FactId = 1,
            FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
            FactLink = "lipsum.com",
            FactHashTags = "",
            FactCreateDate = DateTime.UtcNow,
            FactRating = 5239122
        };
            var m2 = new MDashBoardFact()
            {
                FactId = 2,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 5239122
            };
            var m3 = new MDashBoardFact()
            {
                FactId = 3,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 5239122
            };
            var m4 = new MDashBoardFact()
            {
                FactId = 4,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary #primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 239122
            };
            var m5 = new MDashBoardFact()
            {
                FactId = 5,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 39122
            };
            var m6 = new MDashBoardFact()
            {
                FactId = 6,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 9122
            };
            var m7 = new MDashBoardFact()
            {
                FactId = 7,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 7122
            };
            var m8 = new MDashBoardFact()
            {
                FactId = 8,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam, duis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 4122
            };
            var m9 = new MDashBoardFact()
            {
                FactId = 9,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 2122
            };
            var m10 = new MDashBoardFact()
            {
                FactId = 10,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 122
            };
            var m11 = new MDashBoardFact()
            {
                FactId = 11,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary #primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = -122
            };


            return new MDashBoardFact[] { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11 };
        }


    }
}
