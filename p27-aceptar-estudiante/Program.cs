// Acepta a un estudiante en base a su edad y sus calificaciones
Console.Clear();
Console.WriteLine("Acepta a un estudiante en base a su edad y sus calificaciones\n");
Console.Write("Dame tu nombre ? ");
string nombre = Console.ReadLine();
Console.Write("Dame la edad ? ");
int edad = int.Parse(Console.ReadLine()); 
if( edad >= 18 ) {
Console.WriteLine("Eres mayor de edad, continuamos \n");
Console.WriteLine("Dame dos calificaciones separadas por Enter:");
float c1 = float.Parse(Console.ReadLine());
float c2 = float.Parse(Console.ReadLine());
if( c1 >= 8 && c2 >= 8) 
Console.WriteLine($"\nBIENVENIDO {nombre} tienes {edad} y calificaciones {c1},{c2} ... ACEPTADO\n");
else
Console.WriteLine("\nSolo aceptamos estudiantes con calificaciones de 8 en adelante");
}
else Console.WriteLine("\nSolo aceptamos estudiantes mayores de edad");
Console.WriteLine("\nProceso terminado ...");
