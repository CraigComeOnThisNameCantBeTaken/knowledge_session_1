using System;
using System.Threading.Tasks;

namespace Scalability
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dataContext = new UnmanagedDatabaseConnection();
            var listOfData = await dataContext.GetAllCars();

            foreach (var item in listOfData)
            {
                var manufacturerId = await dataContext.GetManufacturerIdAsync(item.Manufacturer);

                if(manufacturerId != null)
                {
                    await dataContext.UpdateCarStatus(item.Id, true);
                }
            }


        }
    }
}
