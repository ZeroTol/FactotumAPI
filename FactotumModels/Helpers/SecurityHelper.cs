using System;
using System.Linq;
using System.Text;
using FactotumModels;

namespace FactotumAPI.Helpers
{
    public class SecurityHelper
    {
        public string SecurityKey => "mysupers3cr3tsharedkey!";

        private static SecurityHelper _instance;
        public static SecurityHelper Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new SecurityHelper(); 
                }

                return _instance; 
            }
        }

        protected SecurityHelper()
        {
        }

        public bool CheckSecurityKey(string securitykey)
        {
            var keyvalue = securitykey.Substring(7); // Remove Bearer keyword
            var result = SecurityKey.Equals(keyvalue);
            return result;
        }
    }
}
