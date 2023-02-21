// Convertir temperatura de grados celcius a farenheit y viceversa
char op;
float temp, res;
Console.Clear();
Console.WriteLine("Convertir de grados celcius a farenheit y viceversa\n");
Console.WriteLine("[F]arenheit a Centigrados");
Console.WriteLine("[C]entigrados a Farenheit ");
Console.Write("Elije una opcion ? "); op=char.Parse(Console.ReadLine());
op = char.ToUpper(op);
if( op=='F' ) {
Console.WriteLine("\nConvertir de Farenheit a Centigrados\n");
Console.Write("Dame los grados Farenheit ? "); temp=float.Parse(Console.ReadLine());
res = ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
}
else {
Console.WriteLine("\nConvertir de Centigrados a Farenheit\n");
Console.WriteLine("Dame los grados Centigrados ? "); temp=float.Parse(Console.ReadLine());
res = ( temp * 9 / 5 ) + 32;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
}
Console.WriteLine("\nGracias por utilizar este programa");