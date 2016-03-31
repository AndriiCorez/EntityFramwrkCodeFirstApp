using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFrameworkApp
{
    class Program
    {
         static void Main(string[] args)
        {
            //Queries.DisplayBlogsByName();
            Queries.SaveNewBlog();
            Queries.DisplayBlogsByName();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
