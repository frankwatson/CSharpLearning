using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // LINQ syntax
            var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;

            /*foreach (var course in query)
                Console.WriteLine(course.Name);*/

            // Extension methods
            var courses = context.Courses
                .Where(c => c.Name.Contains("c#"))
                .OrderBy(c => c.Name);

            /*foreach (var course in courses)
                Console.WriteLine(course.Name);*/

            var query2 =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Name
                // puts results into new object with specified variables
                select new { Name = c.Name, Author = c.Author.Name };

            var query3 =
                from c in context.Courses
                group c by c.Level into g
                select g;

            foreach (var group in query3)
            {
                /*Console.WriteLine(group.Key);
                foreach (var course in group)
                {
                    Console.WriteLine("\t{0}", course.Name);
                }*/


                /*Console.WriteLine("{0} ({1})", group.Key, group.Count());*/
            }

            var query4 =
                from c in context.Courses
                // Inner join (use if there is no navigation proprty on the other table)
                join a in context.Authors on c.AuthorId equals a.Id
                select new { CourseName = c.Name, AuthorName = a.Name };

            // Using navigation property
            /*select new { CourseName = c.Name, AuthorName = c.Author.Name };*/


            var query5 =
                // Group Join
                //// Join authors with their courses
                from a in context.Authors
                join c in context.Courses on a.Id equals c.AuthorId into g
                select new { AuthorName = a.Name, Courses = g.Count() };
            /*foreach (var x in query5)
                Console.WriteLine("{0} ({1})", x.AuthorName, x.Courses);*/

            var query6 =
                // Cross Join
                from a in context.Authors
                from c in context.Courses
                select new { AuthorName = a.Name, CourseName = c.Name };
            /*foreach (var x in query6)
                Console.WriteLine("{0} - {1}", x.AuthorName, x.CourseName)*/;





            // Extension methods
            var query7 = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(c => c.Level)
                // Projection to anonymous object
                /*.Select(c => new { CourseName = c.Name, AuthorName = c.Author.Name });*/
                // Select Many Projection Method
                .SelectMany(c => c.Tags)
                .Distinct();
            /*foreach (var t in query7)
            {
                Console.WriteLine(t.Name);
            }*/


            // Grouping
            var groups = context.Courses.GroupBy(c => c.Level);
            /*foreach (var group in groups)
            {
                Console.WriteLine("Key: " + group.Key);
                foreach (var course in group)
                    Console.WriteLine("\t " + course.Name);
            }*/





            // Extension Methods
            
            //// Inner join - used when no relationship between objects and we want to relate them
            context.Courses.Join(context.Authors, 
                c => c.AuthorId, 
                a => a.Id, 
                (course, author) => new
            {
                CourseName = course.Name,
                AuthorName = author.Name
            });

            //// Group join - useful in situation where you do a left join between two tables
            //// Matches each object with the list on the left side with one or more objects in the list on the right side
            context.Authors.GroupJoin(context.Courses, a => a.Id, c => c.AuthorId, (author, course) => new
            {
                AuthorName = author,
                Courses = course.Count()
            });

            //// Cross Join - when you have list of left and right and want to return every combination of every object in the two lists
            context.Authors.SelectMany(a => context.Courses, 
                (author, course) => new
            {
                AuthorName = author.Name,
                CourseName = course.Name
            });

            //// Partitioning - useful when you want to return a page of records
            context.Courses.Skip(10).Take(10);

            //// Element Operators - only want single object or first object in list
            context.Courses.OrderBy(c => c.Level).FirstOrDefault(c => c.FullPrice > 100);
            context.Courses.SingleOrDefault(c => c.Id == 1);

            //// Quantifying
            var allAbove100Dollars = context.Courses.All(c => c.FullPrice > 100);
            context.Courses.Any(c => c.Level == 1);

            //// Count
            context.Courses.Where(c => c.Level == 1).Count();
            context.Courses.Max(c => c.FullPrice);
            context.Courses.Min(c => c.FullPrice);
            context.Courses.Average(c => c.FullPrice);




            // Deferred Execution
            var query9 = context.Courses.ToList().Where(c => c.IsBeginnerCourse == true);

            /*foreach (var c in query9)
                Console.WriteLine(c.Name);*/



            // IQueryable
            IQueryable<Course> query10 = context.Courses;
            var qtenFiltered = courses.Where(c => c.Level == 1);
            foreach (var course in qtenFiltered)
                Console.WriteLine(course.Name);
        }
    }
}