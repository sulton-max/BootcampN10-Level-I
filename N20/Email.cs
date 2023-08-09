public interface IEmail
{
    string SenderAddress { get; set; }
    string ReceiverAddress { get; set; }
    string Subject { get; set; }
    string Body { get; set; }

    void DoSomething();
}

public interface IClassifiedInformation
{
    string Secret { get; set; }
}

public class AlertEmail : IEmail, IClassifiedInformation
{
    public string AlertDegree { get; set; }
    public string SenderAddress { get; set; }
    public string ReceiverAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Secret { get; set; }

    public void DoSomething()
    {
        throw new NotImplementedException();
    }
}

public class NotificationEmail : IEmail
{
    public string SenderAddress { get; set; }
    public string ReceiverAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public void DoSomething()
    {
        throw new NotImplementedException();
    }
}

public class OfferEmail : IEmail, IClassifiedInformation
{
    public int Salary { get; set; }
    public string SenderAddress { get; set; }
    public string ReceiverAddress { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Secret { get; set; }

    public void DoSomething()
    {
        throw new NotImplementedException();
    }
}