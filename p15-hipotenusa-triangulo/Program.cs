// Calcular la hipotenusa de un triangulo rectangulo dadas las longitudes de sus lados.
//variables a utilizar.
double longitudLado1, longitudLado2, hipotenusa;
Console.WriteLine("programa que calcule la hipotenusa..");
Console.WriteLine("escriba el valor de LongitudLado1:..");
longitudLado1 = double.Parse(Console.ReadLine());
Console.WriteLine("escriba el valor de LongitudLado2:..");
longitudLado2 = double.Parse(Console.ReadLine());
hipotenusa = Math.Sqrt(longitudLado1*longitudLado1 + longitudLado2*longitudLado2);
Console.WriteLine("el valor de la hipotenusa es :"+hipotenusa);
