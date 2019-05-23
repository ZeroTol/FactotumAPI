using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactotumModels
{
    [Table("User", Schema = "dbo")]
    public class EUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User Id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Username")]
        public String Login { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User password")]
        public String Password { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Create Date")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User IP")]
        public String IP { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User Mac")]
        public String MAC { get; set; }

        [Column(TypeName = "bigint")]
        [Display(Name = "Message Country")]
        public int CountryCodeId { get; set; }

        [Column(TypeName = "bit")]
        [Display(Name = "User banned")]
        public bool Ban { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Modified Date")]
        public DateTime BanDate { get; set; }

        [Column(TypeName = "datetime2(0)")]
        [Display(Name = "Modified Date")]
        public DateTime LastPost { get; set; }

    }
}
