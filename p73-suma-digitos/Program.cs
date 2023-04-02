// Suma los digitos de un numero entero usando una función
double sumadigitos(double n) {
    double suma=0, digito;
    while(n!=0) {
         digito = n % 10;
         n = Math.Truncate( n / 10 );
         suma+=digito;
    }
return suma;
}
double numero;
Console.Write("Dame un numero ? ");
numero = double.Parse(Console.ReadLine());
Console.WriteLine($"\nLa suma de digitos es { sumadigitos(numero) }" );
