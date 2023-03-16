// Suma y promedio de n calificaciones
int n;
float cal, suma, prom;
char resp;
do {
    suma=0;
    Console.Clear();
    suma=prom=0;
    Console.WriteLine("Suma y promedio de n calificaciones: \n");
    Console.Write("Cuantas calificaciones ? ");
    n=int.Parse(Console.ReadLine());
    for(int i=1; i<=n; i++) {
        Console.Write($"Calificacion {i} ? ");
        cal=float.Parse(Console.ReadLine());
        suma+=cal;
    }
    prom=suma/n;
    Console.WriteLine($"\nSuma {suma} y promedio {prom}");
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp != 'N');
    Console.WriteLine("\nProceso Terminado ...");