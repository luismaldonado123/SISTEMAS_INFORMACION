// dado el nombre de un esrudiante y 3 calificaciones decidir si es aceptado.
Console.WriteLine("Aceptar a un estudiante y 3 calificaciones y en base a ellas se decide si es aceptado..");
Console.WriteLine("Dame tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresa el sexo del estudiante : (M o H)");
char sexo = Console.ReadLine()[0]; //leeemos el primer caracter.
Console.Write("Dame la edad ?");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Dame la calificacion 1:");
double calificacion1 = double.Parse(Console.ReadLine());
Console.WriteLine("Dame la calificacion 2:");
double calificacion2 = double.Parse(Console.ReadLine());
Console.WriteLine("Dame la calificacion 3:");
double calificacion3 = double.Parse(Console.ReadLine());
double promedio= (calificacion1 + calificacion2 + calificacion3) /3;
//verificar si cumple
bool aceptacion = sexo == 'm' && edad > 21 &&( (promedio)/3>=8 && (promedio)/3 <= 9.5);
if(aceptacion){
    Console.WriteLine("El estudiante {0} ha sido aceptado en la universidad Kitty Kat SA",nombre);
}else{ 
    Console.WriteLine("lo siento, el estudiante {0} no cumple con los requisitos para entrar a la universidad", nombre);
}