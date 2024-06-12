using Ecommerce;

Console.WriteLine("Hello, World!");


Product p = new Product(112, "Mobile", 758.55, 2);
p.IncreaseStock(3);
Console.WriteLine($"Increase stock " + p.Stock);
p.DecreaseStock(1);
Console.WriteLine($"Decrease stock " + p.Stock);