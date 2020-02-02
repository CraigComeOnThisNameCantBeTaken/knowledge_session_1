using System;
using System.Threading.Tasks;

namespace ExtensibilityRefactoring
{
    // we now want to send an email notification when the database is updated
    // how can we do that without touching the existing code?
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Running Update Script");
            var client = new UpdateDatabase();

            var newValue = 11;
            await client.Update(newValue);
        }
    }
}
