//Se desea imprimir la secuencia de numeros mostrados el numero de renglones que el usuario desee.
int numero,i,j;
char resp;
do{
Console.WriteLine("Cuantos renglones ?");
numero = int.Parse(Console.ReadLine());
for(i=1; i <=numero; i++){
    for(j=1; j<=i; j++){
        Console.Write(i+" ");
    }
    Console.WriteLine();
}
Console.Write("\n deseas continuar (S/N)?");
resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
Console.WriteLine("Proceso terminado");
