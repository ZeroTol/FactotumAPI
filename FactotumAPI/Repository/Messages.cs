using System;
using System.Collections.Generic;
using System.Linq;
using FactotumAPI.Helpers;
using FactotumModels;

namespace FactotumAPI.Repository
{
    public class Messages
    {
        public IEnumerable<EMessage> GetMessages()
        {
            List<EMessage> data = Core.Instance.dbContext.Messages.ToList();
            return data.AsEnumerable();
        }

        public EUser GetUser(int id)
        {
            EUser user = Core.Instance.dbContext.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public IEnumerable<EDashBoardFact> GetDashBoardFacts(string order)
        {
            List<EDashBoardFact> data = null;

            switch (order)
            {
                case null:
                    data = Core.Instance.dbContext.DashBoardFacts.OrderByDescending(m => m.FactRating).ToList();
                    break;

                case "byrating":
                    data = Core.Instance.dbContext.DashBoardFacts.OrderByDescending(m => m.FactRating).ToList();
                    break;

                case "latestrated":
                    data = Core.Instance.dbContext.DashBoardFacts.OrderByDescending(m => m.FactLastRateDate).ToList();
                    break;

                case "latestadded":
                    data = Core.Instance.dbContext.DashBoardFacts.OrderByDescending(m => m.FactCreateDate).ToList();
                    break;

                default:
                    if (data == null)
                        data = Core.Instance.dbContext.DashBoardFacts.OrderByDescending(m => m.FactRating).ToList();
                    break;

            }

            return data.AsEnumerable();
        }

        public EDashBoardFact AppendFact(MDashBoardFact fact)
        {
            var fact_entity = Core.Instance.dbContext.Add(
                new EDashBoardFact()
                {
                    FactTitle = fact.FactTitle,
                    FactLink = fact.FactLink,
                    FactCreateDate = DateTime.Now,
                    FactHashTags = fact.FactHashTags,
                    FactLastRateDate = null,
                    FactRating = 0,
                }).Entity;

            Core.Instance.dbContext.SaveChanges();

            return fact_entity;
        }

        public bool LikeFact(string fact_id)
        {
            var fact_item = Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating++;
            fact_item.FactLastRateDate = DateTime.Now;

            Core.Instance.dbContext.DashBoardFacts.Update(fact_item);

            Core.Instance.dbContext.SaveChanges();

            return true;

        }

        public bool DislikeFact(string fact_id)
        {
            var fact_item = Core.Instance.dbContext.DashBoardFacts.FirstOrDefault(i => i.FactId == int.Parse(fact_id));

            fact_item.FactRating--;
            fact_item.FactLastRateDate = DateTime.Now;

            Core.Instance.dbContext.DashBoardFacts.Update(fact_item);

            Core.Instance.dbContext.SaveChanges();

            return true;

        }

    }
}
