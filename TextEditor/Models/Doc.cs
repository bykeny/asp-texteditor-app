using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextEditor.Models
{
    public class Doc
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
        //[DataType(DataType.DateTime)]
        //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        //[DataType(DataType.DateTime)]
        //public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
