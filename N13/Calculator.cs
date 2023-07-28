namespace N13;

public class Calculator
{
    public int Add(int valueA, int valueB)
    {
        return valueA + valueB;
    }

    public double Add(double valueA, double valueB)
    {
        return valueA + valueB;
    }

    public double Add(double valueA, double valueB, double valueC)
    {
        return valueA + valueB + valueC;
    }

    //public string Add(string valueA, string valueB)
    //{
    //    Console.WriteLine("2 talik");
    //    return valueA + valueB;
    //}

    // Optional parameter - boshlang'ich qiymati bor bo'lgan parameteri
    // Params parameter - 
    public string Add(string valueA, string valueB, string valueC = "")
    {
        return valueA + valueB + valueC;
    }

    // Mumkinmas holatlar 
    // faqat parameter nomi bilan farq qilsa
    // faqat return tipi farq qilsa
    //public double Add(double valueA, double valueC)
    //{
    //    return valueA + valueB;
    //}
    //public decimal Add(double valueA, double valueB)
    //{
    //    return valueA + valueB;
    //}
}