
using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new PlutoContext();

            var courses = context.Courses.Where(c => c.Name.Contains("c#")).OrderBy(c => c.Name);

            foreach (var c in courses)
            {
                Console.WriteLine(c.Name);
            }
            //Make the window not close
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
