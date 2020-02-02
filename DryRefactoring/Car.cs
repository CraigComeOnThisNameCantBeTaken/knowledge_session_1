namespace DryRefactoring
{
    class Car : ICar
    {
        public CarType Type { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
    }
}
