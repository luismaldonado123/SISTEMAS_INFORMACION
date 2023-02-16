// trabajando con numeros enteros
int num1 = 42; 
int num2 = 0x2A;
int num3 = 0b00101010;
sbyte edad = 95;
byte val1 = 230, val2 = 254; 
short horas = 24, dias = 12345;
long ganancia = 123456789000334124;
ulong añosluz = 10000000000000000000;
Console.Clear();
Console.WriteLine($"Todos en formato decimal: {num1} {num2} {num3}");
Console.WriteLine($"num1 base decimal : {num1}");
Console.WriteLine($"num1 base octal : {Convert.ToString(num1,8)}"); // octal
Console.WriteLine($"num2 base hexadecimal : {Convert.ToString(num2,16)}"); // hexadecimal
Console.WriteLine($"num3 base binario : {Convert.ToString(num3,2)}"); // binario
Console.WriteLine($"La ganancia anual : {ganancia:c}"); // moneda (currency)
Console.WriteLine($"Años luz a la luna : {añosluz:e}"); // exponencial
Console.WriteLine($"num2 base dec,hex : {num2:d} , {num2:x}"); // decimal, hexadecimal
Console.WriteLine($"\nTipo: sbyte, \nMin: {sbyte.MinValue} Max: {sbyte.MaxValue}");
Console.WriteLine($"\nTipo: byte, \nMin: {byte.MinValue} Max: {byte.MaxValue}");
Console.WriteLine($"\nTipo: int, \nMin: {int.MinValue} Max: {int.MaxValue}");
Console.WriteLine($"\nTipo: short, \nMin: {short.MinValue} Max: {short.MaxValue}");
Console.WriteLine($"\nTipo: long, \nMin: {long.MinValue} Max: {long.MaxValue}");
Console.WriteLine($"\nTipo: ulong, \nMin: {ulong.MinValue} Max: {ulong.MaxValue}");

