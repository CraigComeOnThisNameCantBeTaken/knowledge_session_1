using System.Collections;

namespace YagniRefactoring
{

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            client.PrintData("a wonderful key");
            client.PrintData("a wonderful key 2");
            client.PrintData("a wonderful key 2");
            client.PrintData("a wonderful key 2");
            client.PrintData("a wonderful key 2");
        }
    }
}
