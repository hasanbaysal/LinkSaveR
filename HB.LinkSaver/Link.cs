using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver
{
    public class Link
    {
        public string Id { get; set; }
        public string Header { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<string> Categories { get; set; } = new();

    }
    public class Category
    {
        public string CategoryName { get; set; }
    }
}
