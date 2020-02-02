using System;
using System.Linq;
using System.Reflection;

namespace DryRefactoring
{
    class CarPrinter
    {
        public void PrintAll()
        {
            var methods = this.GetType()
                .GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.MemberType == System.Reflection.MemberTypes.Method)
                .Where(m => m.Name != nameof(PrintAll))
                .Where(m => m.DeclaringType == typeof(CarPrinter))
                .Select(m => m as MethodInfo)
                .ToArray();

            foreach (var method in methods)
            {
                method.Invoke(this, null);
            }
        }

        public void PrintFourWheelers()
        {
            var dataProvider = new DataProvider();
            var cars = dataProvider.GetData().ToList();

            var fourWheelers = cars.Where(c => c.Type == CarType.fourWheeler);

            foreach (var item in fourWheelers)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Type.ToString());
            }
        }

        public void PrintFourWheelersByTesla()
        {
            var dataProvider = new DataProvider();
            var cars = dataProvider.GetData().ToList();

            var fourWheelers = cars.Where(c => c.Type == CarType.fourWheeler);
            var byTesla = fourWheelers.Where(c => c.Manufacturer == "Tesla");

            foreach (var item in byTesla)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Type.ToString());
            }
        }

        public void PrintThreeWheelers()
        {
            var dataProvider = new DataProvider();
            var cars = dataProvider.GetData().ToList();

            var fourWheelers = cars.Where(c => c.Type == CarType.threeWheeler);

            foreach (var item in fourWheelers)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Type.ToString());
            }
        }

        public void PrintThreeWheelersByReliant()
        {
            var dataProvider = new DataProvider();
            var cars = dataProvider.GetData().ToList();

            var fourWheelers = cars.Where(c => c.Type == CarType.threeWheeler);
            var byTesla = fourWheelers.Where(c => c.Manufacturer == "Reliant");

            foreach (var item in byTesla)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Type.ToString());
            }
        }

        public void PrintCarsWithStolenTyres()
        {
            var dataProvider = new DataProvider();
            var cars = dataProvider.GetData().ToList();

            var unfortunateCars = cars.Where(c => c.Type == CarType.tyresStolenWheeler);

            foreach (var item in unfortunateCars)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Manufacturer);
                Console.WriteLine(item.Type.ToString());
            }
        }
    }
}
