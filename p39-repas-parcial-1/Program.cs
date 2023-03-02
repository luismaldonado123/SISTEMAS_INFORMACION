void Menu() {
    Console.Clear();
    Console.WriteLine("Elija como quiere armar su pizza:");
    Console.WriteLine("Tamano : [C]hica - $5 [M]ediana - $10 [G]rande - $15");
    Console.WriteLine("Ingredientes : [E]xtra queso [C]hampinoness [P]ina, unidos por un '+' - $5 por ingrediente");
    Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
    Console.WriteLine("Donde : [A]qui [L]levar ");
}

char tam, cub, don;
string[] ings;
string tamano = "", ingredientes = "", cubierta = "", donde = "", cliente = "";
float subtot = 0, desc = 0, total = 0, cant = 0;

if(args.Length < 5) {
    Menu();
    return 1;
}
//Procesar Tamano
tam = char.Parse(args[0].ToUpper());
if(tam == 'C'){tamano = "Chica"; subtot+=5;}
else if(tam == 'M'){tamano = "Mediana"; subtot+=10;}
else {tamano = "Grande"; subtot+=15;}

//Proesar Ingredientes
ings = args[1].Split("+");
foreach(string ing in ings){
    switch(char.Parse(ing.ToUpper())){
        case 'E' : ingredientes += "Extraqueso "; break;
        case 'C' : ingredientes += "Champinones "; break;
        case 'P' : ingredientes += "Pina "; break;
    }
    subtot += 5;
}

//Procesar Cubierta
cub = char.Parse(args[2].ToUpper());
cubierta = (cub == 'D' ? "Delgada" : "Gruesa");

//Procesar Donde
don = char.Parse(args[3].ToUpper());
donde = (don == 'A' ? "Aqui" : "Llevar");

//Procesar Cantidad
cant = float.Parse(args[4]);
subtot = subtot * cant;

//Procesar Descuento
if(subtot < 1000){desc = 0.0f; cliente = "Platino";}
else if(subtot <2000){desc = 0.10f; cliente = "Plata";}
else {desc = 0.20f; cliente = "Oro";}

total = subtot - (subtot * desc);

Console.WriteLine($"Tamano:         {tamano}");
Console.WriteLine($"Ingredientes:   {ingredientes}");
Console.WriteLine($"Cubierta:       {cubierta}");
Console.WriteLine($"Donde:          {donde}");
Console.WriteLine($"Cantidad:       {cant}");
Console.WriteLine($"Subtotal:       {subtot:c}");
Console.WriteLine($"Eres Cliente:   {cliente}");
Console.WriteLine($"Descuento:      {desc:p2}");
Console.WriteLine($"Total:          {total:c}");

return 0;