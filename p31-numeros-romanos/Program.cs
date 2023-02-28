// Programa para convertir numero entero entre 1 a 10 en romano
int num;

Console.Clear();
Console.WriteLine("Convertir numero entero entre 1 a 10 en romano...");
Console.WriteLine("Dame un numero entero:"); num = int.Parse(Console.ReadLine());
switch(num) {
    case 1 : Console.WriteLine("I"); break;
    case 2 : Console.WriteLine("II"); break;
    case 3 : Console.WriteLine("III"); break;
    case 4 : Console.WriteLine("IV"); break;
    case 5 : Console.WriteLine("V"); break;
    case 6 : Console.WriteLine("VI"); break;
    case 7 : Console.WriteLine("VII"); break;
    case 8 : Console.WriteLine("VIII"); break;
    case 9 : Console.WriteLine("IX"); break;
    case 10 : Console.WriteLine("X"); break;
    
    default : Console.WriteLine("Del 1 al 10 sabe"); break;
}
Console.WriteLine("\n proceso terminado...");
