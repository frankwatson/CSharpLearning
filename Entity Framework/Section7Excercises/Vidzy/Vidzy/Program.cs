using System;
using System.Linq;
using System.Data.Entity;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            // Lazy Loading
            Console.WriteLine("+-+-+-+-+-+-+-+-+");
            var videos = context.Videos.ToList();

            foreach (var v in videos)
                Console.WriteLine("{0} ({1})", v.Name, v.Genre.Name);

            Console.WriteLine("+-+-+-+-+-+-+-+-+");

            // Eager Loading
            var videosWithGenres = context.Videos.Include(v => v.Genre).ToList();

            foreach (var v in videosWithGenres)
                Console.WriteLine("{0} ({1})", v.Name, v.Genre.Name);
            
            Console.WriteLine("+-+-+-+-+-+-+-+-+");

            // Explicit Loading
            context.Genres.Load();

            foreach(var v in videos)
                Console.WriteLine("{0} ({1})", v.Name, v.Genre.Name);
            
            Console.WriteLine("+-+-+-+-+-+-+-+-+");
        }
    }
}
