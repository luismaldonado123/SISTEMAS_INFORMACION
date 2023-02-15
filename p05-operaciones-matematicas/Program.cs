//efectua operaciones matematicas basica con 2 numeros.
double suma,resta,multi,divi,resi,pote;
Console.Clear();
Console.WriteLine("efectua operaciones matematicas basicas con 2 numeros\n");
double x = 10.5, y= 2.5;
suma = x + y;
resta = x - y;
multi = x * y;
divi = x / y;
resi = x % y;
pote = Math.Pow(x,y);
Console.WriteLine($"Los numeros son: {x}, {y}\n");
Console.WriteLine("el resultado de las operaciones es el siguiente:\n");
Console.WriteLine($"suma:{suma}\n Resta:{resta}\n Multiplicacion:{multi}\n division:{divi}\n residuo:{resi}\n potencia:{pote}\n");

