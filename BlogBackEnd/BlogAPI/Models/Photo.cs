using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Models
{
    internal class Photo
    {
        [Key]
        public Guid Id { get; set; }
        public virtual required BlogPost BlogPost { get; set; }
    }
}
