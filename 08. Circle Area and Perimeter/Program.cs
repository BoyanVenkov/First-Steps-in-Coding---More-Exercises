double r = double.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(r, 2);

double perimeter = 2 * Math.PI * r;

Console.WriteLine($"{area:f2}");
Console.WriteLine($"{perimeter:f2}");