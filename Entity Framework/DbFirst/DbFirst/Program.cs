using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        public enum Level : byte
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = CourseLevel.Beginner;

/*            var dbContext = new PlutoDbContext();
            var courses = dbContext.GetAuthorCourses(1);
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
            }*/
        }
    }
}
