﻿using System.Text.Json;

var customers = new List<Customer>
{
    new (1, "John", "Smith", Country.Uzbekistan),
    new (2, "Jane", "Johnson", Country.UnitedStates),
    new (3, "Michael", "Brown", Country.UnitedKingdom),
    new (4, "David", "Lee", Country.Germany),
    new (5, "Sarah", "Wilson", Country.France),
    new (6, "Emily", "Davis", Country.Japan),
    new (7, "William", "Garcia", Country.China),
    new (8, "James", "Miller", Country.Russia),
    new (9, "Olivia", "Jones", Country.Brazil),
    new (10, "Emma", "Taylor", Country.Australia),
    new (11, "Daniel", "Anderson", Country.Uzbekistan),
    new (12, "Sophia", "Thomas", Country.UnitedStates),
    new (13, "Matthew", "Jackson", Country.UnitedKingdom),
    new (14, "Ava", "White", Country.Germany),
    new (15, "Ethan", "Harris", Country.France),
    new (16, "Isabella", "Martin", Country.Japan),
    new (17, "Noah", "Thompson", Country.China),
    new (18, "Mia", "Moore", Country.Russia),
    new (19, "Liam", "Allen", Country.Brazil),
    new (20, "Charlotte", "Young", Country.Australia),
    new (21, "Jacob", "Scott", Country.Uzbekistan),
    new (22, "Amelia", "Green", Country.UnitedStates),
    new (23, "William", "Baker", Country.UnitedKingdom),
    new (24, "Abigail", "Nelson", Country.Germany),
    new (25, "Alexander", "Carter", Country.France),
    new (26, "Emily", "Mitchell", Country.Japan),
    new (27, "Benjamin", "Perez", Country.China),
    new (28, "Chloe", "Roberts", Country.Russia),
    new (29, "Michael", "Turner", Country.Brazil),
    new (30, "Ella", "Phillips", Country.Australia),
    new (31, "William", "Campbell", Country.Uzbekistan),
    new (32, "Victoria", "Parker", Country.UnitedStates),
    new (33, "James", "Evans", Country.UnitedKingdom),
    new (34, "Grace", "Edwards", Country.Germany),
    new (35, "Daniel", "Collins", Country.France),
    new (36, "Madison", "Stewart", Country.Japan),
    new (37, "Joseph", "Sanchez", Country.China),
    new (38, "Avery", "Morris", Country.Russia),
    new (39, "David", "Rogers", Country.Brazil),
    new (40, "Sofia", "Reed", Country.Australia)
};

var orders = new List<Order>
{
    new (0, 20, 5890, new DateTime(2023, 4, 17)),
    new (1, 16, 9947, new DateTime(2023, 7, 3)),
    new (2, 30, 8054, new DateTime(2023, 2, 22)),
    new (3, 19, 8678, new DateTime(2023, 7, 19)),
    new (4, 13, 1689, new DateTime(2023, 1, 16)),
    new (5, 31, 2356, new DateTime(2023, 11, 12)),
    new (6, 30, 2269, new DateTime(2023, 2, 8)),
    new (7, 31, 4088, new DateTime(2023, 5, 2)),
    new (8, 31, 8163, new DateTime(2023, 6, 1)),
    new (9, 7, 4495, new DateTime(2023, 4, 4)),
    new (10, 3, 9454, new DateTime(2023, 5, 22)),
    new (11, 19, 3016, new DateTime(2023, 10, 18)),
    new (12, 4, 2402, new DateTime(2023, 11, 19)),
    new (13, 19, 1478, new DateTime(2023, 3, 16)),
    new (14, 22, 7710, new DateTime(2023, 8, 7)),
    new (15, 12, 7495, new DateTime(2023, 10, 7)),
    new (16, 17, 3357, new DateTime(2023, 6, 1)),
    new (17, 9, 6136, new DateTime(2023, 8, 15)),
    new (18, 16, 5392, new DateTime(2023, 3, 18)),
    new (19, 17, 8067, new DateTime(2023, 5, 13)),
    new (20, 39, 1541, new DateTime(2023, 6, 17)),
    new (21, 3, 7201, new DateTime(2023, 8, 8)),
    new (22, 40, 1831, new DateTime(2023, 2, 19)),
    new (23, 13, 4493, new DateTime(2023, 3, 23)),
    new (24, 32, 2848, new DateTime(2023, 10, 16)),
    new (25, 22, 506, new DateTime(2023, 8, 8)),
    new (26, 3, 5777, new DateTime(2023, 12, 12)),
    new (27, 34, 5008, new DateTime(2023, 10, 23)),
    new (28, 31, 8126, new DateTime(2023, 4, 5)),
    new (29, 1, 8501, new DateTime(2023, 4, 3)),
    new (30, 32, 9275, new DateTime(2023, 5, 20)),
    new (31, 37, 893, new DateTime(2023, 5, 9)),
    new (32, 34, 1297, new DateTime(2023, 12, 15)),
    new (33, 32, 7030, new DateTime(2023, 3, 20)),
    new (34, 2, 4092, new DateTime(2023, 4, 21)),
    new (35, 17, 4617, new DateTime(2023, 9, 20)),
    new (36, 4, 341, new DateTime(2023, 7, 1)),
    new (37, 27, 1425, new DateTime(2023, 12, 5)),
    new (38, 6, 5667, new DateTime(2023, 4, 19)),
    new (39, 21, 2918, new DateTime(2023, 10, 11)),
    new (40, 17, 7479, new DateTime(2023, 3, 12)),
    new (41, 32, 5881, new DateTime(2023, 6, 3)),
    new (42, 27, 8740, new DateTime(2023, 4, 23)),
    new (43, 13, 4571, new DateTime(2023, 1, 15)),
    new (44, 31, 6015, new DateTime(2023, 1, 16)),
    new (45, 40, 8745, new DateTime(2023, 4, 4)),
    new (46, 7, 5839, new DateTime(2023, 4, 6)),
    new (47, 34, 947, new DateTime(2023, 10, 1)),
    new (48, 27, 9574, new DateTime(2023, 10, 8)),
    new (49, 10, 7151, new DateTime(2023, 3, 21)),
    new (50, 17, 1548, new DateTime(2023, 3, 10)),
    new (51, 2, 7411, new DateTime(2023, 12, 9)),
    new (52, 30, 2290, new DateTime(2023, 9, 7)),
    new (53, 24, 7921, new DateTime(2023, 3, 14)),
    new (54, 14, 6079, new DateTime(2023, 1, 11)),
    new (55, 37, 2953, new DateTime(2023, 6, 9)),
    new (56, 32, 6123, new DateTime(2023, 11, 5)),
    new (57, 17, 3474, new DateTime(2023, 8, 7)),
    new (58, 14, 1715, new DateTime(2023, 3, 12)),
    new (59, 7, 2247, new DateTime(2023, 7, 7)),
    new (60, 22, 886, new DateTime(2023, 12, 17)),
    new (61, 10, 1785, new DateTime(2023, 7, 9)),
    new (62, 25, 2302, new DateTime(2023, 1, 10)),
    new (63, 5, 7261, new DateTime(2023, 10, 19)),
    new (64, 36, 6376, new DateTime(2023, 8, 12)),
    new (65, 8, 6710, new DateTime(2023, 8, 11)),
    new (66, 1, 2956, new DateTime(2023, 7, 19)),
    new (67, 37, 8912, new DateTime(2023, 2, 15)),
    new (68, 9, 1786, new DateTime(2023, 6, 13)),
    new (69, 31, 7980, new DateTime(2023, 7, 8)),
    new (70, 26, 3333, new DateTime(2023, 8, 22)),
    new (71, 35, 9306, new DateTime(2023, 3, 23)),
    new (72, 11, 2805, new DateTime(2023, 8, 10)),
    new (73, 11, 1269, new DateTime(2023, 2, 19)),
    new (74, 28, 2433, new DateTime(2023, 1, 19)),
    new (75, 4, 6657, new DateTime(2023, 7, 13)),
    new (76, 23, 3539, new DateTime(2023, 10, 20)),
    new (77, 2, 1056, new DateTime(2023, 11, 21)),
    new (78, 29, 2384, new DateTime(2023, 12, 11)),
    new (79, 33, 7687, new DateTime(2023, 6, 2)),
    new (80, 31, 2946, new DateTime(2023, 8, 16)),
    new (81, 16, 7023, new DateTime(2023, 1, 11)),
    new (82, 10, 8294, new DateTime(2023, 2, 18)),
    new (83, 6, 8662, new DateTime(2023, 2, 11)),
    new (84, 16, 9638, new DateTime(2023, 5, 4)),
    new (85, 3, 7748, new DateTime(2023, 4, 16)),
    new (86, 7, 3438, new DateTime(2023, 7, 23)),
    new (87, 39, 2121, new DateTime(2023, 3, 1)),
    new (88, 29, 6207, new DateTime(2023, 3, 7)),
    new (89, 30, 7096, new DateTime(2023, 9, 12)),
    new (90, 7, 9150, new DateTime(2023, 11, 7)),
    new (91, 23, 527, new DateTime(2023, 2, 6)),
    new (92, 4, 4679, new DateTime(2023, 4, 5)),
    new (93, 11, 8585, new DateTime(2023, 6, 12)),
    new (94, 17, 5432, new DateTime(2023, 1, 10)),
    new (95, 30, 9566, new DateTime(2023, 6, 7)),
    new (96, 16, 9235, new DateTime(2023, 8, 2)),
    new (97, 17, 567, new DateTime(2023, 12, 6)),
    new (98, 12, 7386, new DateTime(2023, 10, 12)),
    new (99, 16, 4283, new DateTime(2023, 1, 10))
};

var ordersByCustomer = customers.GroupJoin(orders,
        customer => customer.Id,
        order => order.CustomerId,
        (customer, customerOrders) => new
        {
            Customer = customer,
            Orders = customerOrders
        })
    .GroupBy(orderByCustomersGroupedByCountry => orderByCustomersGroupedByCountry.Customer.Country)
    .Where(orderByCustomersFromUk => orderByCustomersFromUk.Key == Country.UnitedKingdom)
    .SelectMany(orderByCustomersFromUk => orderByCustomersFromUk)
    .Select(orderByCustomer => orderByCustomer with
    {
        Orders = orderByCustomer.Orders.Where(order => order.Amount > 5000 && (DateTime.Now - order.OrderDate).TotalDays < 30)
    })
    .Where(orderByCustomer => orderByCustomer.Orders.Any())
    .ToList();

Console.WriteLine(JsonSerializer.Serialize(ordersByCustomer));

public enum Country
{
    Uzbekistan,
    China,
    Russia,
    Brazil,
    Australia,
    Germany,
    France,
    Japan,
    UnitedKingdom,
    UnitedStates
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Country Country { get; set; }

    public Customer(int id, string firstName, string lastName, Country country)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Country = country;
    }
}

public class Order
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int id, int customerId, int amount, DateTime orderDate)
    {
        Id = id;
        Amount = amount;
        CustomerId = customerId;
        OrderDate = orderDate;
    }
}