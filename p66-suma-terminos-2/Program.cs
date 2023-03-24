//Se desea imprimir la secuencia de términos armónicos el número de renglones que el usuario desee y su suma
Console.Clear();
int numero,i;
double suma = 0.3f,termino=0.3f;
char resp;
do{
    Console.WriteLine("Cuántos terminos?");
    numero = int.Parse(Console.ReadLine());
    for(i=1; i<=numero; i++){
        termino = int.Parse(new string('1',i));
        Console.Write(termino);
        if(i!=numero){
            Console.Write("+");
        }
        suma = suma + termino;
    }
    Console.WriteLine($"\nSuma {suma,3}\n");
    Console.Write("\n deseas continuar (S/N)?");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
Console.WriteLine("Proceso terminado");
