using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NETCoreAPI.Models
{
    [Table("todo_items")]
    public class TodoItem
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public long Id { get; set; }

        [MaxLength(50), Required]    
        [Column("title", TypeName = "varchar(80)")]
        public string Title { get; set; }

        [MaxLength(400), Required]
        [Column("description", TypeName = "varchar(400)")]
        public string Description { get; set; }

        
        [Column("is_done")]
        public bool IsDone { get; set; }
    }
}
