//programa que calcula el tiempo.
double dias=0, horas=0, minutos=0, segundos=0;
Console.WriteLine("programa que calcula el tiempo..");
Console.Write("Ingresa las horas");
horas = double.Parse(Console.ReadLine());
dias = horas / 24;
minutos = horas * 60;
segundos = horas * 60 * 60;
Console.WriteLine($"el tiempo calculado es: {dias} dias, {horas} horas, minutos {minutos}, segundos {segundos}");