// Suma de pares e impare
int op, n, s, i;
do {
    Console.Clear();
    Console.WriteLine("Impares ascendente .... [ 1 ]");
    Console.WriteLine("Pares descentente...... [ 2 ]");
    Console.WriteLine("Salir ....... [ 3 ]");
    Console.Write("Elije ? "); op=int.Parse(Console.ReadLine());
    switch(op) {
    case 1:{
    s=0;
    Console.WriteLine("\nImpares ascendenbte y su suma:");
    Console.Write("Hasta donde ? "); n=int.Parse(Console.ReadLine());
        for(i=1; i<=n; i+=2) {
        Console.Write($"{i} ");
        s+=i;
    }
    Console.WriteLine($"\nLa suma de impares es {s}");
    }break;
    case 2:{
    s=0;
    Console.WriteLine("\nPares descendente y su suma:");
    Console.WriteLine("Hasta donde ? ");n=int.Parse(Console.ReadLine());
    n = ( n%2==0 ? n : --n);
        for(i=n; i>=1; i-=2) {
        Console.Write($"{i} ");
        s+=i;
    }
    Console.WriteLine($"\nLa suma de pares es {s}");
    }break;
    case 3:
        Console.WriteLine("\nTe vas por que quieres nadie te corre");break;
    default:
    Console.WriteLine("\nOpcion Invalida"); 
    break;
    Console.WriteLine("\nPresiona cualquier tecla para continuar");Console.ReadLine();
    }
} while( op != 3);
Console.WriteLine("\nProceso terminado ...");