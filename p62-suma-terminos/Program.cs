// Suma de n términos de factorial
int i,j,n;
float f, r;
char resp;
do {
    Console.Clear();
    r=0;
    Console.Write("Cuantos números ? "); n = int.Parse(Console.ReadLine());
    for(i=1; i<=n; i++) {
       f=1;
        for(j=1; j<=i; j++) {
        f *= j;
    }   
    Console.Write($" 1 / {i}! +");
    r += (1 / f);
}
Console.WriteLine($"= {r}");
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
    Console.WriteLine("\nProceso terminado ..");