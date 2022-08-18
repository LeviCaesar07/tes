using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Mahasiswa1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nama {get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
