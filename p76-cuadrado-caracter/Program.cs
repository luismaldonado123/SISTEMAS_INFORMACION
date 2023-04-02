
// Imprime un cuadro de r x c del caracter especificado, usando una función
void cuadro(int r, int c, char car) {
    for(int i=1;i<=r;i++) {
        for(int j=1;j<=c;j++)
            Console.Write($"{car} ");
        Console.WriteLine("");
    }
}
int r,c;
char car;
Console.Clear();
Console.Write("Renglones : "); r = int.Parse(Console.ReadLine());
Console.Write("Columnas : "); c = int.Parse(Console.ReadLine());
Console.WriteLine("De que caracter ? ");
car = Console.ReadLine()[0];
cuadro(r,c,car);