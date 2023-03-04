// dado un numero entero entre 1 y 6 que corresponde a un continente del mundo, escribir su nombre
int validar=0;
Console.WriteLine("dado un numero entero entre 1 y 6 que corresponde a un continente del mundo, escribir su nombre, ejemplo 1 :Asia");
Console.WriteLine("Dame un numero del 1 al 6..");
validar = int.Parse(Console.ReadLine());
if(validar > 6){
    Console.WriteLine("Fuera de rango, intente de nuevo");
}else{
    switch(validar){
    case 1 : Console.WriteLine("Asia"); break;
    case 2 : Console.WriteLine("Africa"); break;
    case 3 : Console.WriteLine("America del norte"); break;
    case 4 : Console.WriteLine("America del sur"); break;
    case 5 : Console.WriteLine("Antartida"); break;
    case 6 : Console.WriteLine("Europa"); break;
    default:break;
    }
    Console.WriteLine("\n proceso terminado...");
}

