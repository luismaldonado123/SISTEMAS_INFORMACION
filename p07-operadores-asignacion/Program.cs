// Utiliza los operadores de asignacion para efectuar diversas operaciones
Console.Clear();
Console.WriteLine("Efectuando diversas operaciones usando los operadores de asignacion:\n");

Console.Write("Dame un numero ?\n");
float num = float.Parse(Console.ReadLine());

Console.WriteLine($"El numero original  es : {num}");
Console.WriteLine($"Incrementar 1 : {++num}");
Console.WriteLine($"sumar 80 : {num+=80}");
Console.WriteLine($"Restar 35 : {num-=35}");
Console.WriteLine($"Multiplicar por 15 : {num*=15}");
Console.WriteLine($"Dividir entre 4 : {num/=4}");
Console.WriteLine($"Decrementar 1 : {--num}");