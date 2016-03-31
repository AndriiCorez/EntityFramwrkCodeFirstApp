using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFrameworkApp
{
    class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        //This enables the Lazy Loading feature of EF - contents of these properties 
        //will be automatically loaded from the database when you try to access them.
        public virtual Blog Blog { get; set; }
    }
}
