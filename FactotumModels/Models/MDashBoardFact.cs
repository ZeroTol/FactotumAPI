using System;
using System.Collections.Generic;
using System.Text;

namespace FactotumModels
{
    public class MDashBoardFact
    {

        public int Id { get; set; }
        public Guid FactId { get; set; }
        public int FactRating { get; set; }
        public DateTime FactCreateDate { get; set; }
        public String FactTitle { get; set; }
        public String FactHashTags { get; set; }
        public String FactLink { get; set; }
        public DateTime? FactLastRateDate { get; set; }
    }
}
