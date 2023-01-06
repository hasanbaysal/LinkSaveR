using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkSaveR.CRUD
{
    public class Link
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string? LinkData { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }

    }
}
