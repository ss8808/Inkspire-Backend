

using Inksprie_Backend.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inksprie_Backend.Entities
{
    [Table("User")]
    public class User 
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public GenderType? Gender { get; set; }
        public string? ImageURL { get; set; }

        public DateTime RegisteredDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; }

    }
}
