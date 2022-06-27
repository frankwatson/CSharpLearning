using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can change behavior of dbMigrator without changing code using interfaces

            // var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\Frank\Documents\Git\C#\Intermediate Course\Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
