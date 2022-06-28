
using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Don't have to use finally block with .Dispose() method
                using (var streamReader = new StreamReader(@"C:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }


/*            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
