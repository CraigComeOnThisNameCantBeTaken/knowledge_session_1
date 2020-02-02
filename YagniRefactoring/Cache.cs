using System.Collections.Generic;
using System.Threading.Tasks;

namespace YagniRefactoring
{
    // although this is a console app and so it is not a long running execution, incase these values in cache become out of data we will clear the cache every 5 minutes
    class Cache
    {
        private IDictionary<string, int> MemoryCache { get; set; }
        private static Cache Instance { get; set; }

        private Cache()
        {
            MemoryCache = new Dictionary<string, int>();
            Invalidate();
        }

        private void Invalidate()
        {
            Task.Delay(300000).ContinueWith((l) => Task.Run(() => {
                MemoryCache = new Dictionary<string, int>()
                Invalidate();
            }));
        }

        public bool TryGet(string key, out int value)
        {
            return MemoryCache.TryGetValue(key, out value);
        }

        public void Set(string key, int value)
        {
            MemoryCache[key] = value;
        }

        public static Cache GetInstance()
        {
            if (Instance != null)
            {
                return Instance;
            }

            Instance = new Cache();

            return Instance;
        }
    }
}
