double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());

double lengthCm = length * 100;
double widthCm = width * 100 - 100;

double desksPerRow = Math.Floor(widthCm / 70);
double rows = Math.Floor(lengthCm / 120);

double totalDesks = desksPerRow * rows - 3;

Console.WriteLine(totalDesks);