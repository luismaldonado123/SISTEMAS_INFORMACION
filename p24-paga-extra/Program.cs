// Calcular la paga de un trabajador
int horas, extra;
float paga, total;
Console.Clear();
Console.WriteLine("Calculando la paga de un trabajador \n");
Console.Write("Dame las horas ? "); horas=int.Parse(Console.ReadLine());
Console.Write("Dame la paga ? "); paga=float.Parse(Console.ReadLine());
if( horas > 40 ) {
extra = horas - 40;
total = (40*paga) + (extra * paga * 2);
Console.WriteLine($"\nHoras extra: {extra}");
}
else total = horas * paga;
Console.WriteLine($"\nPago total: {total:f2}");
