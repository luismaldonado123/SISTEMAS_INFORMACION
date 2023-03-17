// Imprime números impares ascendente
int numero,cantidad=0,suma=0;
double promedio;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime números impares descendente\n");
    Console.Write("Desde donde ? ");
    numero = int.Parse(Console.ReadLine());
    for(int i =1; i<=numero; i++){
        if(i%2!=0){
            Console.Write(i+" ");
            suma = suma + i;
            cantidad++;
        }
    }
    promedio = (double)suma/cantidad;
Console.WriteLine($"\nLa suma es es {suma}");
Console.WriteLine($"el promedio es {promedio}");
Console.Write("\nDeseas continuar (S/N) ? ");
resp = char.ToUpper( Console.ReadLine()[0] );
} while( resp!='N' );
Console.WriteLine("\nGracias por utilizar este programa !");
