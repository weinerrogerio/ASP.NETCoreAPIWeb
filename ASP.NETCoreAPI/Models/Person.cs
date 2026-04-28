using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreAPI.Models
{
    [Table("person")]
    public class Person
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(80)]
        [Column("first_name", TypeName ="varchar(80)")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(80)]
        [Column("last_name", TypeName = "varchar(80)")]
        public string LastName { get; set; }= string.Empty;

        [MaxLength(100)]
        [Column("address", TypeName = "varchar(100)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [MaxLength(6)]
        [Column("gender", TypeName = "varchar(6)")]
        public string Gender { get; set; }

    }
}
