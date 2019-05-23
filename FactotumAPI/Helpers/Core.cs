using System;
using System.Linq;
using FactotumAPI.Repository;
using FactotumModels;

namespace FactotumAPI.Helpers
{
    public class Core
    {
        public FMDataContext dbContext { get; }
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
    }
}
