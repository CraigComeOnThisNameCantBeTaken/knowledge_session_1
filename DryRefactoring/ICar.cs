namespace DryRefactoring
{
    interface ICar
    {
        string Manufacturer { get; set; }
        string Name { get; set; }
        CarType Type { get; set; }
    }
}