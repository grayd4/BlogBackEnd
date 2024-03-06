using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBackEnd
{
    internal class User
    {

        public Guid Id { get; set; }
        public string? Name { get; set; }

        public DateTime? CreatedDate { get; set; }

        // Virtual allows lazy loading
        // Contents auto loaded when they are accessed
        public virtual List<BlogPost>? Posts { get; set; }

    }
}
