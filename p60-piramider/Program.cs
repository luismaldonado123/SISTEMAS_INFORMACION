// Imprime una pirámide del caracter
int i,j,n;
char car, resp;
do {
    Console.Clear();
    Console.Write("Cuantos renglones ? "); n = int.Parse(Console.ReadLine());
    Console.Write("De que caracter ? "); car = Console.ReadLine()[0];
    for(i=1; i<=n; i++) {
       for(j=1; j<=i; j++) {
           Console.Write($"{car}");
        }
    Console.WriteLine();
    }
    Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
    Console.WriteLine("\nProceso terminado ..");