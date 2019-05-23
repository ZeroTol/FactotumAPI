using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactotumModels
{
    [Table("Options", Schema = "dbo")]
    public class EOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Max User Daily Posts")]
        public int UserDailyPosts { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Post alive days")]
        public int PostPeriod { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Options Modified Date")]
        public DateTime ModifiedDate { get; set; }
    }
}
