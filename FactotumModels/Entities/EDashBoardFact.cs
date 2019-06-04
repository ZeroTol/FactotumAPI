using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FactotumModels
{
    [Table("DashBoardFacts", Schema = "dbo")]
    public class EDashBoardFact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Fact Id")]
        public int FactId { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Title")]
        public String FactTitle { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Link")]
        public String FactLink { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Fact Create Date")]
        public DateTime? FactCreateDate { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Fact Rating")]
        public int FactRating { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Fact Hash Tags")]
        public String FactHashTags { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Fact Last Rate Date")]
        public DateTime? FactLastRateDate { get; set; }
    }
}
