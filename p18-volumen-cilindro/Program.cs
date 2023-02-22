// programa que calcula el volumen de un cilindro
double radio, volumen, altura;
Console.WriteLine("programa que calcula el volumen de un cilindro..");
Console.WriteLine("ingresa el radio:");
radio = double.Parse(Console.ReadLine());
Console.WriteLine("dame la altura:");
altura = double.Parse(Console.ReadLine());
volumen = radio*radio*altura*Math.PI;
Console.WriteLine($"el volumen es: {volumen}");
