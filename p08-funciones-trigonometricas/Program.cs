// Calcula funciones trigonometricas de un angulo en radianes
Console.Clear();
Console.WriteLine("Calculando las funciones trigonometricas de un angulo en radianes:\n");

Console.WriteLine("Dame un angulo en Radianes:");
double angulo = double.Parse(Console.ReadLine());

double seno = Math.Sin(angulo);
double coseno = Math.Cos(angulo);
double tangente = Math.Tan(angulo);

Console.WriteLine($"El angulo {angulo}, tiene las siguientes funciones trigonometricas:\n");
Console.WriteLine($"seno {0:f4} , coseno {1:f4}, Tangente {2:f4}", Math.Sin(angulo),Math.Cos(angulo),Math.Tan(angulo));


