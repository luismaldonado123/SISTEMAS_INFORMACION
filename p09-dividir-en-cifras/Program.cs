// Divide un numero de 3 cifras en unidades, decenas y centenas
double unidades, decenas,centenas;
Console.Clear();
Console.WriteLine("Dividiendo un numero de 3 cifras en unidades, decenas y centenas:\n");
Console.Write("dame un numero entero de 3 cifras:");
double num = double.Parse(Console.ReadLine());

centenas = Math.Truncate(num / 100);
decenas = Math.Truncate((num - centenas * 100)/10);
unidades = Math.Truncate(num -(centenas * 100 + decenas * 10) );

Console.WriteLine($"Centenas : {centenas}, Decenas:  {decenas}, Unidades: {unidades}");
