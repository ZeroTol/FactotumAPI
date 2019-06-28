using System;
using System.Collections.Generic;
using FactotumModels;
using System.Linq;

namespace FactotumAPI.Repository
{

    public class FakeMessages
    {
        #region OldTrash
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

        public static IEnumerable<MDashBoardFact> GetDashBoardMessages()
        {
            var m1 = new MDashBoardFact()
            {
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
        #endregion

        private static IEnumerable<EDashBoardFact> FactCollection ;

        static FakeMessages()
        {
            // create fact collection for further use
            var f1 = new EDashBoardFact()
            {
                FactId = 1,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 5239122,
                FactLastRateDate = DateTime.UtcNow,
            };
            var f2 = new EDashBoardFact()
            {
                FactId = 2,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 5239122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f3 = new EDashBoardFact()
            {
                FactId = 3,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 5239122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f4 = new EDashBoardFact()
            {
                FactId = 4,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary #primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 239122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f5 = new EDashBoardFact()
            {
                FactId = 5,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 39122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f6 = new EDashBoardFact()
            {
                FactId = 6,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 9122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f7 = new EDashBoardFact()
            {
                FactId = 7,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 7122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f8 = new EDashBoardFact()
            {
                FactId = 8,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam, duis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam",
                FactLink = "lipsum.com",
                FactHashTags = "",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 4122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f9 = new EDashBoardFact()
            {
                FactId = 9,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 2122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f10 = new EDashBoardFact()
            {
                FactId = 10,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f11 = new EDashBoardFact()
            {
                FactId = 11,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary #primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = -122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f12 = new EDashBoardFact()
            {
                FactId = 12,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 12,
                FactLastRateDate = DateTime.UtcNow
            };
            var f13 = new EDashBoardFact()
            {
                FactId = 13,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 2122,
                FactLastRateDate = DateTime.UtcNow
            };
            var f14 = new EDashBoardFact()
            {
                FactId = 14,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 14,
                FactLastRateDate = DateTime.UtcNow
            };
            var f15 = new EDashBoardFact()
            {
                FactId = 15,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 15,
                FactLastRateDate = DateTime.UtcNow
            };
            var f16 = new EDashBoardFact()
            {
                FactId = 9,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 16,
                FactLastRateDate = DateTime.UtcNow
            };
            var f17 = new EDashBoardFact()
            {
                FactId = 9,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 17,
                FactLastRateDate = DateTime.UtcNow
            };
            var f18 = new EDashBoardFact()
            {
                FactId = 18,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 18,
                FactLastRateDate = DateTime.UtcNow
            };
            var f19 = new EDashBoardFact()
            {
                FactId = 19,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 19,
                FactLastRateDate = DateTime.UtcNow
            };
            var f20 = new EDashBoardFact()
            {
                FactId = 20,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 20,
                FactLastRateDate = DateTime.UtcNow
            };
            var f21 = new EDashBoardFact()
            {
                FactId = 21,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 21,
                FactLastRateDate = DateTime.UtcNow
            };
            var f22 = new EDashBoardFact()
            {
                FactId = 22,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 22,
                FactLastRateDate = DateTime.UtcNow
            };
            var f23 = new EDashBoardFact()
            {
                FactId = 23,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 23,
                FactLastRateDate = DateTime.UtcNow
            };
            var f24 = new EDashBoardFact()
            {
                FactId = 24,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 24,
                FactLastRateDate = DateTime.UtcNow
            };
            var f25 = new EDashBoardFact()
            {
                FactId = 25,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 25,
                FactLastRateDate = DateTime.UtcNow
            };
            var f26 = new EDashBoardFact()
            {
                FactId = 26,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 26,
                FactLastRateDate = DateTime.UtcNow
            };
            var f27 = new EDashBoardFact()
            {
                FactId = 9,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 27,
                FactLastRateDate = DateTime.UtcNow
            };
            var f28 = new EDashBoardFact()
            {
                FactId = 28,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 28,
                FactLastRateDate = DateTime.UtcNow
            };
            var f29 = new EDashBoardFact()
            {
                FactId = 29,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 29,
                FactLastRateDate = DateTime.UtcNow
            };
            var f30 = new EDashBoardFact()
            {
                FactId = 30,
                FactTitle = "Ruis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam.",
                FactLink = "lipsum.com",
                FactHashTags = "#primary",
                FactCreateDate = DateTime.UtcNow,
                FactRating = 30,
                FactLastRateDate = DateTime.UtcNow
            };

            FactCollection = new EDashBoardFact[] { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10,
                                                    f11, f12, f13, f14, f15, f16, f17, f18, f19, f20,
                                                    f21, f22, f23, f24, f25, f26, f27, f28, f29, f30
                                                  };
            //            return new EDashBoardFact[] { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11 };
        }

        public static IEnumerable<EDashBoardFact> GetDashBoardFacts(string order)
        {
            List<EDashBoardFact> asList = FactCollection.ToList();
            switch (order)
            {
                case "byrating":
                    return asList.OrderByDescending(m => m.FactRating);

                case "latestrated":
                    return asList.OrderByDescending(m => m.FactLastRateDate);

                case "latestadded":
                    return asList.OrderByDescending(m => m.FactCreateDate);
                default:
                    return FactCollection;
            }
        }

        public static bool LikeFact(string fact_id)
        {
            var fact_item = FactCollection.FirstOrDefault(i => i.FactId == int.Parse(fact_id));//Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating++;
            fact_item.FactLastRateDate = DateTime.Now;

            return true;

        }

        public static bool DislikeFact(string fact_id)
        {
            var fact_item = FactCollection.FirstOrDefault(i => i.FactId == int.Parse(fact_id));//Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating--;
            fact_item.FactLastRateDate = DateTime.Now;

            //Core.Instance.dbContext.DashBoardFacts.Update(fact_item);
            //Core.Instance.dbContext.SaveChanges();

            return true;

        }

        public static EDashBoardFact AppendFact(MDashBoardFact fact)
        {
            var newFact = new EDashBoardFact()
            {
                FactTitle = fact.FactTitle,
                FactLink = fact.FactLink,
                FactCreateDate = DateTime.Now,
                FactHashTags = fact.FactHashTags ?? "",
                FactLastRateDate = null,
                FactRating = 0
            };

            var myList = FactCollection.ToList();
            myList.Add(newFact);

            FactCollection = myList.AsEnumerable();

            //var fact_entity = Core.Instance.dbContext.Add(
            //    new EDashBoardFact()
            //    {
            //        FactTitle = fact.FactTitle,
            //        FactLink = fact.FactLink,
            //        FactCreateDate = DateTime.Now,
            //        FactHashTags = fact.FactHashTags,
            //        FactLastRateDate = null,
            //        FactRating = 0,
            //    }).Entity;

            //Core.Instance.dbContext.SaveChanges();

            return newFact;
        }

    }
}
