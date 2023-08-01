namespace N17.CopyCtor
{
    internal class Bmw
    {
        public Guid Id { get; set; }

        public string ModelName { get; set; }

        public Engine Engine { get; set; }

        public Bmw(string modelName, Engine engine)
        {
            Id = Guid.NewGuid();
            ModelName = modelName;
            Engine = new Engine(engine);
        }

        public Bmw(Bmw bmw)
        {
            Id = bmw.Id;
            ModelName = bmw.ModelName;
            Engine = new Engine(bmw.Engine);
        }
    }
}
