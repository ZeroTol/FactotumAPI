using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactotumModels
{
    [Table("Message", Schema = "dbo")]
    public class EMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Message Id")]
        public int Id { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Message Title")]
        public String Title { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Message Link")]
        public String Link { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Message Rating")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Message Rating")]
        public int Rating { get; set; }

        [Column(TypeName = "bigint")]
        [Display(Name = "Message Country")]
        public int CountryCodeId { get; set; }

        [Column(TypeName = "bigint")]
        [Display(Name = "Message Description")]
        public int DescriptionId { get; set; }

        [Column(TypeName = "bigint")]
        [Display(Name = "Message User")]
        public int UserId { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "Message Removed flag")]
        public int Removed { get; set; }

    }
}
