namespace N16.InitOnlyProperty
{
    internal class User
    {
        public string Name { get; init; } = "";

        public User(string value)
        {
            //Name = name;
            //Name = firstName;
        }

        public void DoSomething()
        {
            //Name = "";
        }
    }
}
