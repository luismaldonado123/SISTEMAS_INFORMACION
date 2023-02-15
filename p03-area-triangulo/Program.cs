// calcula el area de un triangulo
int ba, al;
float ar;
Console.WriteLine("Calcular el area de un triangulo\n");
Console.Write("dame la base :");
ba = int.Parse(Console.ReadLine());
Console.Write("dame la altura :");
al = int.Parse(Console.ReadLine());
ar = ba * al / 2;
Console.WriteLine($"Un triangulo de base {ba} y altura {al} tiene un area de {ar}");
