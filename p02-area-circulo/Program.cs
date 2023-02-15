//cacula el area de circulo
double area,radio;
Console.WriteLine("Calculando el area de un circulo:\n");
Console.Write("dame el radio > ");
radio = double.Parse(Console.ReadLine());
area = Math.PI * Math.Pow(radio,2);
Console.WriteLine($"El circulo de radio {radio} tiene un area de {area}");
Console.WriteLine("El tipo de dato de las variables es :");
Console.WriteLine(radio.GetType());
Console.WriteLine(area.GetType());
