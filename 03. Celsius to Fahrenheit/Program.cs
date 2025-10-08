//°F = (°C × 9/5) + 32

double celsius = double.Parse(Console.ReadLine());

double farenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"{farenheit:f2}");