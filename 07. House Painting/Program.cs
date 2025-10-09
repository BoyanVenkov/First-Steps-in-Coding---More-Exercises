double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine()); 


double frontBack = 2 * (x * x) - (1.2 * 2);


double sides = 2 * (x * y) - 2 * (1.5 * 1.5);

double totalGreenArea = frontBack + sides;

double greenPaint = totalGreenArea / 3.4;

double roofRectangles = 2 * (x * y);

double roofTriangles = 2 * (x * h / 2);

double totalRedArea = roofRectangles + roofTriangles;

double redPaint = totalRedArea / 4.3;

Console.WriteLine($"{greenPaint:F2}");
Console.WriteLine($"{redPaint:F2}");

