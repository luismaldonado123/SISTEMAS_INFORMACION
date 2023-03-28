// suma de un rango de numeros
float SumaRango(float ini, float fin) {
    float s=0;
    for(float i=ini; i <= fin ;i++)
        s+=i;
    return s;
}
float i, f, res;
Console.Clear();
do {
    Console.Write("Dame inicio : "); i = float.Parse(Console.ReadLine());
    Console.Write("Dame fin : "); f = float.Parse(Console.ReadLine());
} while( i > f);
    res = SumaRango(i, f);
    Console.WriteLine($"\nLa suma del rango es {res:n2}");
