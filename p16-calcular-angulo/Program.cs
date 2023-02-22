// calcular el 3er angulo de un triangulo dado los 2 primeros angulos.
double angulo1,angulo2,angulo3;
Console.WriteLine("welcome to the program that calculates an angle based on 2 others..");
Console.WriteLine("dame el angulo 1:..");
angulo1 = double.Parse(Console.ReadLine());
Console.WriteLine("dame el angulo 2");
angulo2 = double.Parse(Console.ReadLine());
angulo3 = 180 - (angulo1 + angulo2);
Console.WriteLine("el resultado al angulo 3 es el siguiente.."+angulo3);

