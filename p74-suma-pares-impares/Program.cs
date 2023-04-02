// Imprime pares o impares y su suma, usando función
int sumapi(int ini, int fin, char letra) {
    int suma=0;
    for(int i=ini; i <= fin; i++) {
        if(letra=='P' && i%2==0) {
            Console.Write($"{i} ");
            suma+=i;
        }
        else if(letra=='I' && i%2!=0) {
                Console.Write($"{i} ");
                suma+=i;
        }
    }
    return suma;
}
int ini,fin,suma;
char letra;
Console.Write("Valor incial : "); ini = int.Parse(Console.ReadLine());
Console.Write("Valor final : "); fin = int.Parse(Console.ReadLine());
Console.Write("[P]ares o [I]mpares ? ");
letra = char.ToUpper(Console.ReadLine()[0]);
suma = sumapi(ini,fin,letra);
Console.Write($"\nLa suma es {suma}");