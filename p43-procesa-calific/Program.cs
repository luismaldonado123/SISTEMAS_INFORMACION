// procesa n calificaciones, calcula suma y promedio de calificaciones
Console.Clear();
int n,c;
float calf=0,suma=0,prom=0;
Console.WriteLine("Procesa n calificaciones, calcula la suma y el promedio");
Console.WriteLine("Cuantas calificaciones?");
n = int.Parse(Console.ReadLine());
c=1;
while(c <= n){
    Console.WriteLine($"calificacion{c++}");
    calf = float.Parse(Console.ReadLine());
    suma += calf;
}
prom = suma / n;
Console.WriteLine($"La suma es : {suma:f2}");
Console.WriteLine($"El promedio es : {prom:f2}");

