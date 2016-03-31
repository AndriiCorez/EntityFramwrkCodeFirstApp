using CodeFirstEntityFrameworkApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFrameworkApp
{
    class Queries
    {
        public static void SaveNewBlog()
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Enter a name for a blog to create: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }

        public static void DisplayBlogsByName()
        {
            using (var db = new BloggingContext())
            {
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("Blogs:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);            
                }
            }
        }
    }
}
