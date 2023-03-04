// en base a los precios y la compra que realize se le hace un descuento.
int precio=0;
string size="patito";
double descuento=0.0f,subtotal;
Console.WriteLine("bienvenido a una de las mejores pizzerias! pizza planeta");
Console.WriteLine("[C]hica --> precio $5.00");
Console.WriteLine("[M]ediana --> precio $10.00");
Console.WriteLine("[G]rande --> precio $20.00");
Console.WriteLine("elige una opcion :");
char tamaño = char.ToUpper(Console.ReadLine()[0]);
Console.WriteLine("¿Cuantas pizzas deseas?");
int cantidad = int.Parse(Console.ReadLine());
switch(tamaño){
    case 'C':
    precio = 5;
    size = "chica";
    break;
    case 'M':
    precio = 10;
    size = "mediana";
    break;
    default:
    precio = 20;
    size = "grande";
    break;
}
subtotal = precio * cantidad;
if(subtotal <= 2000){
    descuento = 0.0f;
}else{
    descuento = 0.15f;
}
Console.WriteLine("el pedido fue procesado");
Console.WriteLine($"El tamaño de su pizza es : {size} con un precio de ${precio} por pizza");
Console.WriteLine($"la cantidad que usted ordeno es : {cantidad}");
Console.WriteLine($"el precio sin descuento es : ${subtotal}");
Console.WriteLine($"su descuento es de : {double.Round(descuento,2)*100}%");
Console.WriteLine($"el total con el descuento aplicado es de : ${double.Round (subtotal - descuento * subtotal,2)}");
