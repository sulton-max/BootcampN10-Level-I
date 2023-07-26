

// code reuse - code bitta joyda yozish va qayta ishlatish
// abstraction - abstraksiya
// inheritance - vorislik
// vorislikda - data va behavior

// this
// base



//var bmw = new BMW("X5");

// Object initialization syntax - ixtiyoriy
// new Type
// {
//   Member = value
// }
//

var bmw = new BMW("M5");

Console.WriteLine(bmw.Model);

//var porsche = new Porsche();

//bmw.Drive();
//porsche.Drive();

public class Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Starting the engine");
        Console.WriteLine("Accelerating");
    }
}

public class BMW : Vehicle
{
    public string Model { get; set; }

    // Constructor
    // Tipdan object olganda ishlaydi
    // Tip nomi bilan bir xil
    // Vazifasi - boshlang'ich vazifalarni bajarish
    // Hech nima qaytarmaydi
    public BMW(string model)
    {
        Model = model;

        Console.WriteLine("Showing BMW logo");
        Drive();
        Console.WriteLine("Checking door");
    }

    // this ni ishlatilishi
    //public void Test(BMW value)
    //{
    //    Console.WriteLine(value.Model);
    //    Console.WriteLine(this.Model);
    //}

    // this ni ishlatilishi
    //public void Test(string Model)
    //{
    //    this.Model = Model;
    //}
}

public class Porsche : Vehicle
{

}