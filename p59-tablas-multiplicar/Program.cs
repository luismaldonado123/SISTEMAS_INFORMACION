// Tablas de multiplicar con de 1 a n hasta la del n
int i,j,n,m;
char resp;
do {
    Console.Clear();
    Console.Write("Hasta que tabla ? "); n = int.Parse(Console.ReadLine());
    Console.Write("Hasta donde ? "); m = int.Parse(Console.ReadLine());
    for(i=1; i<=n; i++) {
        Console.WriteLine($"\nTabla del {i}");
        for(j=1; j<=m; j++) {
        Console.WriteLine($"{i} x {j} = {i*j}");
        }
    }
Console.WriteLine("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nProceso terminado ..");
