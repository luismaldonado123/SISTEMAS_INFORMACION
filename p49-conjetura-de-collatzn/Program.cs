// Imprime la conjetura de collatz para un número entero positivo
int n;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime la conjetura de collatz para un número entero positivo\n");
    do {
    Console.Write("Dame un numero positivo ? ");
    n = int.Parse(Console.ReadLine());
    } while( n < 0);
    do {
    Console.Write($"{n} ");
    if(n%2==0)
    n = n / 2;
    else
    n = n * 3 + 1;
} while(n!=1);
    Console.WriteLine(n);
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
    Console.WriteLine("\nGracias por utilizar este programa !");