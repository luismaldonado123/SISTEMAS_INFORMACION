// Imprime el factorial de un número, usando una función
double factorial(int n) {
    double f=1;
    for(int i=1; i <= n; i++)
        f=f*i;
    return f;
}
Console.Write("Dame un numero ? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"\nEl factorial es {factorial(n)}");
