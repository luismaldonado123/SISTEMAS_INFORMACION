// Calcular la paga total de un trabajador
string nombre;
int horas;
float paga, pagabruta, paganeta, impuesto, tasa;
Console.WriteLine("Calculando la paga de un trabajador");
//entrada
Console.Write("nombre ?"); 
nombre = Console.ReadLine();
Console.Write("Horas Trabajadas ?");
horas = int.Parse(Console.ReadLine());
Console.Write("paga por hora ?");
paga = float.Parse(Console.ReadLine());
tasa = 0.3f;
//calculo
pagabruta = horas * paga;
impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;
//salida
Console.WriteLine("resumen de pagos");
Console.WriteLine($"El trabajador {nombre}, trabajo {horas} horas, con una paga de {paga} pesos la hora, se asume una tasa de impuesto de {tasa}%");
Console.WriteLine($"Paga bruta: {pagabruta}");
Console.WriteLine($"impuesto: {impuesto}");
Console.WriteLine($"Paga neta: {paganeta}");


