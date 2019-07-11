using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FactotumModels
{
    //[Table("DashBoardFacts", Schema = "dbo")]
    public class EDashBoardFact
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        //[Key, Column(Order = 0)]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Fact Id")]
        public Guid FactId { get; set; }

        //[Key, Column(TypeName = "int", Order = 1)]
        [Display(Name = "Fact Rating")]
        public int FactRating { get; set; }

        //[Key, Column(TypeName = "datetime2(0)", Order = 2)]
        [Display(Name = "Fact Create Date")]
        public DateTime FactCreateDate { get; set; }
        
        //[Key, Column(TypeName = "datetime2(0)", Order = 3)]
        [Display(Name = "Fact Last Rate Date")]
        public DateTime? FactLastRateDate { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Title")]
        public String FactTitle { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Link")]
        public String FactLink { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Hash Tags")]
        public String FactHashTags { get; set; }
    }
}
