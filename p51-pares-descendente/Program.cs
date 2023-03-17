// Imprime numeros pares descendente
int n,c=100,s=0,carry=0;
double promedio=0; 
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime numoros pares descendente desde 100 hasta el que le digas\n");
    Console.WriteLine("Hasta donde ?");
    n = int.Parse(Console.ReadLine());
    while(c >= n){
        Console.Write($"\t{c}");
        s = s + c;
        c = c - 2;
        carry++;
    }
     promedio = (double)s/carry;
    Console.WriteLine($"\nLa suma es {s,3}\n");
    Console.WriteLine($"\nEl promedio es: {promedio}\n");
    Console.Write("\n deseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
 Console.WriteLine("\n Gracias por utilizar el programa");
