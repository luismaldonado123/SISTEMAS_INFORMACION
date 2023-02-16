// trabajando con flotantes
float num1 = 423.45f;
float num2 = 123f;
float num3 = 1.94e-8f;
double num4 = 1322332.4567d;
double num5 = .3456;
decimal val1 = .10m;
decimal val2 = 56789.77e23m;
Console.Clear();
Console.WriteLine($"num1 y num2 en formato normal : {num1} y {num2} "); // formato general
Console.WriteLine($"num6 y val2 en formato exponencial : {num3:e} "); // formato exponencial
Console.WriteLine($"num3 y num4 en formato normal 2 decimales : {num4:f2} y {num5:f2} "); // formato normal, 2 decimales
Console.WriteLine($"val1 en formato porcentaje : {val1:p2} "); // formato de porcentaje, dos decimales
Console.WriteLine($"num7 en formato numérico : {val2:n2} "); // formato numérico con separador de miles, 2 decimales
Console.WriteLine($"num7 en formato moneda : {val2:c} "); // formato moneda
Console.WriteLine($"\nTipo: float, \nMin: {float.MinValue:n} \nMax: {float.MaxValue:n}");
Console.WriteLine($"\nTipo: double, \nMin: {double.MinValue:n} \nMax: {double.MaxValue:n}");
Console.WriteLine($"\nTipo: decimal, \nMin: {decimal.MinValue:n}\nMax: {decimal.MaxValue:n}");