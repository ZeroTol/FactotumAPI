using System;
using System.Linq;
using FactotumAPI.Repository;
using FactotumModels;
using FactotumModels.Context;

namespace FactotumAPI.Helpers
{
    public class Core
    {
        public FMDataContext dbContext { get; }

        public FtDbContext ftDbContext { get; }

        public Messages MessageService { get; }
        public Options Options { get; }

        private static Core _instance;
        public static Core Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Core();
                }

                return _instance;
            }
        }

        protected Core()
        {
            try
            {
                ftDbContext = new FtDbContext();
                var dashboard = dbContext.DashBoardFacts;
                EDashBoardFact eDashBoardFact = null;
                if ((dashboard != null) && (dashboard.Count() > 0))
                {
                    eDashBoardFact = dashboard.First();
                }

                dbContext = new FMDataContext();
                var options = dbContext.Options;
                EOptions option = null;
                if ((options != null) && (options.Count() > 0))
                {
                    option = options.First();
                }

                Options = new Options(option);
                MessageService = new Messages();

            }
            catch (Exception)
            {

            }
        }
    }
}
