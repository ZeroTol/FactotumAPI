using System;
using System.Collections.Generic;
using System.Linq;
using FactotumModels;

namespace FactotumAPI.Repository
{
    public class Messages
    {
        static private FMDataContext dbContext = new FMDataContext();

        public Messages()
        {
        }

        public static IEnumerable<EMessage> GetMessages()
        {
            List<EMessage> data = Messages.dbContext.Messages.ToList();
            return data.AsEnumerable();
        }

        public static EUser GetUser(int id)
        {
            EUser user = Messages.dbContext.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }
    }
}
