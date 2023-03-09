// numeros del 100 al 1, hacia atras.
Console.Clear();
int c,n,p;
Console.Write("hasta donde ?"); n = int.Parse(Console.ReadLine());
Console.Write("paso ?"); p = int.Parse(Console.ReadLine());
c = n;
while(c >= 1){
    Console.Write(c+" ");
    c-=p;
}
Console.WriteLine("\nproceso terminado\n");
