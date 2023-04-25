//medidas de longitud con funciones
Console.Clear();
int op;
double pulgadas,centimetros,metros,pies;
do{
    Console.WriteLine("Elige una opcion:");
    Console.WriteLine("Convertir de pulgadas a centimetros.... [1]");
    Console.WriteLine("Convertir de centimetros a pulgadas.... [2]");
    op = int.Parse(Console.ReadLine());
    switch (op){
        case 1:
        Console.WriteLine("dame las pulgadas:");
        pulgadas = double.Parse(Console.ReadLine());
        centimetros = PA(pulgadas);
        Console.WriteLine($"las pulgadas son {pulgadas} a centimetros {centimetros}");
    break;
    case 2:
        Console.WriteLine("dame  los metros:");
        metros = double.Parse(Console.ReadLine());
        pies = MA(metros);
        Console.WriteLine($"los metros {metros} a pies son {pies}");
        break;
        default:
        Console.WriteLine("negacion");
        break;
    }
}while(op!=2);
double MA(double metros){ //metros a pies
        return metros * 3.28;
} 
double PA(double pulgadas){ //pulgadas a centimetros
    return pulgadas * 2.54;
}
