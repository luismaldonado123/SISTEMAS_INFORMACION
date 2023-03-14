// Imprime numeros pares ascendente
int n,c=0,s=2;
char resp;
do{
    Console.Clear();
    Console.WriteLine("Imprime numoros pares ascendente\n");
    Console.WriteLine("Hasta donde ?");
    n = int.Parse(Console.ReadLine());
    while(c <=n){
        Console.Write($"\t{c}");
        s = s + c;
        c = c + 2;
    }
    Console.WriteLine($"\nLa suma es {s,3}\n");
    Console.Write("\n deseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
 Console.WriteLine("\n Gracias por utilizar el programa");