
// Numeros de n a 1 con paso de p
Char resp;
do{
    Console.Clear();
    Console.WriteLine("// Numeros de 1 a n con paso de p \n");
    Console.Write("Hasta donde ? "); int n=int.Parse(Console.ReadLine());
    Console.Write("Paso ? "); int p=int.Parse(Console.ReadLine());
    for(int i=n; i>=1; i-=p) {
        Console.Write($"{i,3} ");
    }
    Console.WriteLine("\nDeseas continuar ? (S/N)");
    resp = char.ToUpper(Console.ReadLine()[0]);
}while(resp!='N');
 Console.WriteLine("\n proceso terminado");
