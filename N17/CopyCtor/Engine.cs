namespace N17.CopyCtor
{
    internal class Engine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    

        public Engine(string name)
        {
            Id = Guid.NewGuid();
            Name = name;    
        }

        // Copy constructor
        public Engine(Engine engine)
        {
            Id = engine.Id;
            Name = engine.Name;
        }
    }
}
