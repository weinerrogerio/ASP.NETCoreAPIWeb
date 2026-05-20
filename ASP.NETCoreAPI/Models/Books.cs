using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreAPI.Models
{
    [Table("books")]
    public class Books
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime Launch_date { get; set; }

      
    }
}
