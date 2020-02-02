using System;

namespace YagniRefactoring
{
    class Client
    {
        public void PrintData(string key)
        {
            var cache = Cache.GetInstance();
            if (!cache.TryGet(key, out int value))
            {
                // get data from database
                value = new Random().Next(1, 1000);
                cache.Set(key, value);
            }

            Console.WriteLine(value);
        }
    }
}
