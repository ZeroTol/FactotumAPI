using System;
using System.Collections.Generic;
using System.Text;

namespace FactotumModels
{
    public class MDashBoardMessage
    {

        public int FactId { get; set; }

        public String FactTitle { get; set; }

        public String FactHashTags { get; set; }

        public String FactLink { get; set; }

        public DateTime FactCreateDate { get; set; }

        public int FactRating { get; set; }
    }
}
