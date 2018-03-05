
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
            Console.WriteLine("### Courses of Level one ###");

            var courses2 = context.Courses.Where(c => c.Level == 1)
                .OrderBy(c => c.Name)
                .ThenByDescending(c => c.Level);
                

            foreach (var c in courses2)
            {
                Console.WriteLine(string.Format("Course: {0}- Level: {1}",c.Name,c.Level));
            }

            Console.WriteLine("### Courses  ###");

            var tags = context.Courses.Where(c => c.Level == 1)
                .OrderBy(c => c.Name)
                .ThenByDescending(c => c.Level)
                .Select(c => c.Author)
                .Distinct();

            foreach (var t in tags)
            {
                Console.WriteLine(t.Name);
            }

            //Make the window not close
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
