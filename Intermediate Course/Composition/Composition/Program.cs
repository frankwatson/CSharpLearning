using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faster way
            var dbMigrator = new DBMigrator(new Logger());

            // Other way
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
