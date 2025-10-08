double mackarelKg = double.Parse(Console.ReadLine());
double spratKg = double.Parse(Console.ReadLine());
double palamudKg = double.Parse(Console.ReadLine());
double safridKg = double.Parse(Console.ReadLine());
double musselKg = double.Parse(Console.ReadLine());

double PalamudPrice = mackarelKg * 1.6;
double safridPrice = spratKg * 1.8;

double totalPrice = (palamudKg * PalamudPrice) + (safridKg * safridPrice) + (musselKg * 7.50);

Console.WriteLine($"{totalPrice:f2}");