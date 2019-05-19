using System;
namespace FactotumModels
{
    public class MMessage
    {
        public int? Id { get; set; }
        public String Title { get; set; }
        public String Link { get; set; }
        public int Rating { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public Boolean Removed { get; set; }
    }
}
