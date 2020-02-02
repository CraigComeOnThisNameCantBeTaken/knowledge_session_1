using System.Threading.Tasks;

namespace ExtensibilityRefactoring
{
    class UpdateDatabase
    {
        public async Task Update(int newValue)
        {
            // database hit here
            await Task.Delay(100);
        }
    }
}
