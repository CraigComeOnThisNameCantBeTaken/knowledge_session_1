using System.Collections.Generic;

namespace DryRefactoring
{
    class DataProvider
    {
        public IEnumerable<ICar> GetData()
        {
            return new List<ICar> {
                    new Car {
                        Name = "Model 3",
                        Type = CarType.fourWheeler,
                        Manufacturer = "Tesla"
                    },
                    new Car {
                        Name = "Batmobile",
                        Type = CarType.fourWheeler,
                        Manufacturer = "Wayne"
                    },
                     new Car {
                        Name = "Robin",
                        Type = CarType.threeWheeler,
                        Manufacturer = "Reliant"
                    }
                };
        }
    }
}
