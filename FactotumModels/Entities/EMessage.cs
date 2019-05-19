using System;
namespace FactotumModels
{
    public class EMessage
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Link { get; set; }
        public int Rating { get; set; }
        public int DescriptionId { get; set; }
        public String Date { get; set; }
        public bool Removed { get; set; }
        public int UserId { get; set; }
    }
}
