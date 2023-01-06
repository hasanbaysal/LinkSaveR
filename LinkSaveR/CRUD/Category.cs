using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkSaveR.CRUD
{
    public class Category
    {
        public Category()
        {
            Link= new List<Link>(); 
        }
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<Link> Link{ get; set; }

    }
}
