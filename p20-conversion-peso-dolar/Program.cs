// programa que convierte de pesos a dolares.
double dolar, peso, equivalente;
Console.WriteLine("programa que convierte de pesos a dolares");
Console.WriteLine("ingrese la cantidad en pesos mexicanos");
peso = Double.Parse(Console.ReadLine());
Console.WriteLine("dame el precio del dolar:");
dolar = Double.Parse(Console.ReadLine());
equivalente = peso/dolar;
Console.WriteLine($"el equivalente de pesos en dolares es:{equivalente}");

