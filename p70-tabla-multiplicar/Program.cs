// Tabla de multiplicar
void Tabla(int t, int n) {
    Console.WriteLine($"\nTabla del {t}");
    for(int i=1; i <= n; i++)
        Console.WriteLine($"{t} x {i} = {t*i}");
}
Console.Write("Que tabla deseas ? ");
int t = int.Parse(Console.ReadLine());
Console.Write("Hasta donde ? ");
int n = int.Parse(Console.ReadLine());
Tabla(t,n);
