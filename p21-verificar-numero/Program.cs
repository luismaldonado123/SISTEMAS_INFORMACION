// verifica si un numero es positivo, negativo o cero
int n;
Console.WriteLine("verifica si un numero es positivo, negativo o cero");
Console.WriteLine("dame un numero?:");
n = int.Parse(Console.ReadLine());
if(n>0) Console.WriteLine("el numero es positivo..");
if(n<0) Console.WriteLine("el numero es negativo..");
if(n==0) Console.WriteLine("el numero es cero..");

Console.WriteLine("Gracias por utilizar este programa");