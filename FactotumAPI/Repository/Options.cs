using System;
using FactotumModels;

namespace FactotumAPI.Repository
{
    public class Options
    {

        const int defUserDailyPosts = 100;
        const int defPostPeriod = 5;

        public Options()
        {
                this.UserDailyPosts = defUserDailyPosts;
                this.PostPeriod = defPostPeriod;
                this.ModifiedDate = DateTime.Now;
        }

        public Options(EOptions options)
        {
            if (options != null)
            {
                this.UserDailyPosts = options.UserDailyPosts;
                this.PostPeriod = options.PostPeriod;
                this.ModifiedDate = options.ModifiedDate;
            }
            else
            {
                this.UserDailyPosts = defUserDailyPosts;
                this.PostPeriod = defPostPeriod;
                this.ModifiedDate = DateTime.Now;
            }
        }

        public int UserDailyPosts { get; set; }
        public int PostPeriod { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
