// dado un numero entre 1 y 7 imprime el dia de la semana
int dia;
Console.Clear();
Console.WriteLine("dado un numero entre 1 y 7 imprime el dia de la semana(1 lunes)\n");
Console.Write("dame el dia con numero ?"); dia = int.Parse(Console.ReadLine());
switch(dia){
    case 1 : Console.WriteLine("lunes"); break;
    case 2 : Console.WriteLine("martes"); break;
    case 3 : Console.WriteLine("miercoles"); break;
    case 4 : Console.WriteLine("jueves"); break;
    case 5 : Console.WriteLine("viernes"); break;
    case 6 : Console.WriteLine("sabado"); break;
    case 7 : Console.WriteLine("domingo"); break;
    default : Console.WriteLine("en que dia vives cabezon??"); break;
}
Console.WriteLine("\n proceso terminado\n");