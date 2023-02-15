// Calcula el promedio de 3 calificaciones, calcula tambien la mayor y la menor.
float cal1,cal2,cal3,suma,prom,mayor,menor;
cal1=cal2=cal3=0;
Console.WriteLine("Calculando el promedio de 3 calificaciones, calculando tambien la mayor y la menor:\n");
Console.WriteLine("Dame calificacion 1:"); cal1= float.Parse(Console.ReadLine());
Console.WriteLine("Dame calificacion 2:"); cal2= float.Parse(Console.ReadLine());
Console.WriteLine("Dame calificacion 3:"); cal3= float.Parse(Console.ReadLine());

suma = cal1 + cal2 + cal3;
prom = suma / 3;
mayor = Math.Max(Math.Max(cal1,cal2),cal3);
menor = Math.Min(Math.Min(cal1,cal2),cal3);

Console.WriteLine($"Las calificaciones introducidas son: {cal1},{cal2},{cal3}\n");
Console.WriteLine($"La suma : {suma:f2}\n El promedio : {prom:f2}\n El mayor: {mayor:f2}\n El menor: {menor:f2}\n");