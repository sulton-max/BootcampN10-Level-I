namespace N13;

public class Bmw : Vehicle
{
    public string Model { get; set; }

    // Constructor
    // Tipdan object olganda ishlaydi
    // Tip nomi bilan bir xil
    // Vazifasi - boshlang'ich vazifalarni bajarish
    // Hech nima qaytarmaydi
    public Bmw(string model)
    {
        Model = model;

        Console.WriteLine("Showing BMW logo");
        Drive();
        Console.WriteLine("Checking door");
    }

    public void DriveBMW()
    {
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