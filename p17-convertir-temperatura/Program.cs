//programa que convierte de grados fahrenheit a celcius
double celcius, fahrenheit;
Console.WriteLine("programa que convierte de gradis fahrenheit a celcius...");
Console.WriteLine("dame los grados fahrenheit:");
fahrenheit = double.Parse(Console.ReadLine());
celcius = (fahrenheit -32) * 5/9;
Console.WriteLine($"tus grados celcius son:{celcius}");