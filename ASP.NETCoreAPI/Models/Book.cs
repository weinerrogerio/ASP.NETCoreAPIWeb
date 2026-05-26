using ASP.NETCoreAPI.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreAPI.Models
{
    [Table("book")]
    public class Book : BaseEntity
    {        

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
