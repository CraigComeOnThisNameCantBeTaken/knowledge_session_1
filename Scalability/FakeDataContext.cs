using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scalability
{
    class UnmanagedDatabaseConnection : IDisposable
    {
        public async Task<Car> GetCarAsync(int id)
        {
            var randomValue = new Random().Next(1, 100).ToString();
            var car = new Car
            {
                Id = id,
                Name = randomValue,
                Manufacturer = "hopefully not skoda"
            };
            return await Task.FromResult(car);
        }

        public async Task<int?> GetManufacturerIdAsync(string name)
        {
            return await Task.FromResult(new Random().Next(1, 100));
        }

        public async Task UpdateCarStatus(int id, bool value)
        {
            return;
        }

        public async Task<IEnumerable<Car>> GetAllCars() {
            var ids = new int[]
            {
                1,
                33,
                54,
                19
            };

            return await Task.WhenAll(ids.ToList().Select(GetAsync));
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
