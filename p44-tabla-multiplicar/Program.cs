// imprime la tabla de multiplicar que el usuario pida, desde 1 hasta n.
int c,t,n;
Console.Clear();
Console.WriteLine("Imprime la tabla de multiplicar que el usuario pida, desde 1 hasta n");
Console.Write("Que tabla quieres?");
t = int.Parse(Console.ReadLine());
Console.Write("Hasta donde?");
n = int.Parse(Console.ReadLine());
c=1;
while(c <=n){
    Console.WriteLine($" {c,3} * {t,4} = {c*t}");
    c++;
}
Console.WriteLine("\n proceso terminado");
