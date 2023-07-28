namespace N13;

public class Interviewer : User
{
    public Interviewer(string firstName, string lastName, string middleName = "")
        : base(firstName, lastName, middleName)
    {
        Console.WriteLine("Interviewerdaig 1-konstruktor ishladi");
    }
}