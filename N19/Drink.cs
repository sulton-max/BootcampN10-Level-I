namespace N19;

    public class Drink
    {
        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public int Price { get; }
    }