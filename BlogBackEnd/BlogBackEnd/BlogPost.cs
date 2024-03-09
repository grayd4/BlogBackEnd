using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBackEnd
{
    internal class BlogPost
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public DateTime? Created { get; set; }

        // Virtual allows lazy loading
        // Contents auto loaded when they are accessed
        public virtual required User Author { get; set; }
    }
}
