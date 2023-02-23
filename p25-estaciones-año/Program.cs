// Muestra la estación del año que corresponde al número introducido
Console.Clear();
Console.WriteLine("Muestra la estacion del año en base al número:\n");
Console.Write("Dame un numero (1..4) ? ");
int n = int.Parse(Console.ReadLine());
if(n>=1 && n<=4){
    if(n==1) Console.WriteLine("Primavera\n");
    if(n==2) Console.WriteLine("Verano\n");
    if(n==3) Console.WriteLine("Otoño\n");
    if(n==4) Console.WriteLine("Invierno\n");
}else Console.WriteLine("\nen que planeta vives?");