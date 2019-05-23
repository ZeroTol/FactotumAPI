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
    }
}
