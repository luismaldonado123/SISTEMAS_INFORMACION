// Imprime números impares descendente
int n,c,s;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números impares descendente\n");
    Console.Write("Desde donde ? ");
    n = int.Parse(Console.ReadLine());
    s=0;
    c = ( n%2==0 ? --n : n);
while( c>=1 ) {
    Console.Write($"{c,3} ");
    s = s + c;
    c = c-2;
}
Console.WriteLine($"\nLa suma es {s}");
Console.Write("\nDeseas continuar (S/N) ? ");
resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp!='N' );
Console.WriteLine("\nGracias por utilizar este programa !");