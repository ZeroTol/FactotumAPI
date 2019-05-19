using System;
namespace FactotumModels
{
    public class MUser
    {
        public int? Id { get; set; }
        public String IP { get; set; }
        public String MAC { get; set; }
        public bool Ban { get; set; }
        public String BanDate { get; set; }
        public String LastPost { get; set; }
    }
}
