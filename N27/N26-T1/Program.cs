using System.Text.Json;
using N26_T1;

var skillsA = new List<Skill>
{
    new("Vue", 3),
    new("Angular", 7),
    new("React", 2),
    new(".NET", 6),
    new("Python", 3),
};

Console.WriteLine(JsonSerializer.Serialize(skillsA));
Console.WriteLine();

var updatedItemA = skillsA[2];
updatedItemA.Name = "CSS";
var updatedItemB = skillsA[3];
updatedItemB.Level = 10;

var skillB = new List<Skill>
{
    new("Ruby", 3),
    new("Swift", 5),
    updatedItemA,
    updatedItemB,
    skillsA[0],
    skillsA[3],
};

Console.WriteLine(JsonSerializer.Serialize(skillB));
Console.WriteLine();

var result = skillsA.Update(skillB);
Console.WriteLine(JsonSerializer.Serialize(result));

namespace N26_T1
{
    public enum MoneyType
    {
    }


    public class Money
    {
        public int Amount { get; set; }
        public MoneyType Type { get; set; }

        public Money(int amount, MoneyType type)
        {
            Amount = amount;
            Type = type;
        }

        public Money()
        {
        }

        public static Money operator +(Money first, Money last)
        {
// - moneyA va moneyB bir xil tipda bo'lsa - qo'shiladi
// - moneyA in balance va moneyB loan bo'lsa - moneyA - moneyB qilinadi
// - moneyB loan va moneyB in balance bo'lsa - moneyB - moneyA qilinadi

            if (first.Type == last.Type)
            {
                return new Money(first.Amount + last.Amount, first.Type);
            }
            else
            {
            }

            return new Money();
        }
    }

    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        public Skill(string name, int level)
        {
            Id = Guid.NewGuid();
            Name = name;
            Level = level;
        }
    }

    public static class CollectionExtensions
    {
        public static ICollection<Skill> Update(this ICollection<Skill> first, ICollection<Skill> second)
        {
            var list = first.ToList();
            var addedItems = second.ExceptBy(first.Select(firstItem => firstItem.Id), item => item.Id);
            var removedItems = first.ExceptBy(second.Select(firstItem => firstItem.Id), item => item.Id);
            var intersectedKeys = first.Select(item => item.Id).Intersect(second.Select(item => item.Id));

            foreach (var item in addedItems)
                list.Add(item);

            foreach (var item in removedItems)
                list.Remove(item);

            foreach (var key in intersectedKeys)
            {
                var firstItem = list.First(x => x.Id == key);
                var secondItem = second.First(x => x.Id == key);

                firstItem.Name = secondItem.Name;
                firstItem.Level = secondItem.Level;
            }

            return list;
        }
    }
}