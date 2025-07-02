

List<car> cars = new List<car>()
{
    new Audi(),
    new BMW(),
    new Dzire(),
    new BMW(),
    new BMW(),
    new Dzire(),

};

//filter BMW cars
//var carresult = cars.OfType<Dzire>();

var carresult = cars.OfType<BMW>();
foreach (var car in carresult)
{
    Console.WriteLine($"{car.name}car\t");
}

Console.Read();