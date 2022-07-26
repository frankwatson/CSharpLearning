using System;
using System.Collections.Generic;
using System.Linq;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            // Action movies sorted by name
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            var query1 = context.Videos
                .Where(v => v.Genre.Name == "Action")
                .OrderBy(v => v.Name);

            foreach (var v in query1)
                Console.WriteLine(v.Name);

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            // Gold drama movies sorted by release data (newest first)
            var query2 = context.Videos
                .Where(v => v.GenreId == 7 && v.Classification == Classification.Gold)
                .OrderByDescending(v => v.ReleaseDate);

            foreach (var v in query2)
                Console.WriteLine(v.Name);

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            // All movies projected into an anonymous type with two properties
            //// MovieName and Genre
            var query3 = context.Videos
                .Select(v => new { MovieName = v.Name, Genre = v.GenreId });


            foreach (var v in query3)
                Console.WriteLine(v.MovieName);

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            // All movies grouped by their classification
            var query4 = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key.ToString(),
                    Videos = g.OrderBy(v => v.Name)
                });

            foreach (var i in query4)
            {
                Console.WriteLine("Classification: " + i.Classification);
                
                foreach (var m in i.Videos)
                    Console.WriteLine("\t " + m.Name);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            // List of classifications sorted alphabetically and count of videos in them
            var query5 = context.Videos
                .GroupBy(v => v.Classification)
                .Select(g => new
                {
                    Classification = g.Key.ToString(),
                    Count = g.Count()
                })
                .OrderBy(c => c.Classification);

            foreach(var v in query5)
            {
                Console.WriteLine("{0} ({1})", v.Classification, v.Count);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");

            // List of genres and number of videos they invlude, sorted by the number of videos
            var query6 = context.Genres
                .GroupJoin(context.Videos, g => g.Id, v => v.GenreId, (genre, video) => new
                {
                    Genre = genre.Name,
                    Count = video.Count()
                })
                .OrderBy(g => g.Genre);

            foreach(var i in query6)
            {
                Console.WriteLine("{0} ({1})", i.Genre, i.Count);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+");
        }
    }
}
