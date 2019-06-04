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
    }
}
