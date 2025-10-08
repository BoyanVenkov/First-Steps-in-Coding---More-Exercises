double vegPrice = double.Parse(Console.ReadLine());
double fruitPrice = double.Parse(Console.ReadLine());
double vegKg = double.Parse(Console.ReadLine());
double fruitKg = double.Parse(Console.ReadLine());

double euro = ((vegPrice * vegKg) + (fruitPrice * fruitKg)) / 1.94;

Console.WriteLine($"{euro:f2}");