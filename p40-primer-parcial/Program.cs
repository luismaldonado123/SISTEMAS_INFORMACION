// primer examen parcial
int tipoUsuario, tipoPaquete, cantidad;
double precioUsuario, precioPaquete, subtotal, descuento,total;

Console.WriteLine("Ingrese el tipo de usuario:");
Console.WriteLine("[1] Alumno $100");
Console.WriteLine("[2] Trabajador $200");
Console.WriteLine("[1] Docente $500");
tipoUsuario = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de paquete:");
Console.WriteLine("[1] Solo conferencias $600");
Console.WriteLine("[2] Con eventos sociales $800");
Console.WriteLine("[3] Con kit de acceso $900");
tipoPaquete = int.Parse(Console.ReadLine());

Console.WriteLine("ingresa la cantidad:");
cantidad = int.Parse(Console.ReadLine());
//evaluar tipo de usuario

switch(tipoUsuario){
    case 1:
    precioUsuario=100;
    break;
    case 2:
    precioUsuario=200;
    break;
    case 3:
    precioUsuario=500;
    break;
default:
    Console.WriteLine("tipo de usuario no valido..");
    return;    
}
switch(tipoPaquete){
    case 1:
    precioPaquete=600;
    break;
    case 2:
    precioPaquete=800;
    break;
    case 3:
    precioPaquete=900;
    break;
default:
Console.WriteLine("tipo de paquete no valido");
    return; 
}
subtotal = (precioUsuario + precioPaquete) *cantidad;
if(subtotal > 5000){
    switch(tipoUsuario){
        case 1:
        descuento = subtotal * 0.02;
        break;
        case 2:
        descuento = subtotal * 0.1;
        break;
        case 3:
        descuento = subtotal * 0.05;
        break;
     default:
        descuento=0;
        break;   
    }
}else{
    descuento=0;
}
total = subtotal - descuento;

Console.WriteLine("Tipo de usuario: {0}",tipoUsuario);
Console.WriteLine("Tipo de paquete : {0}",tipoPaquete);
Console.WriteLine("Tu pedido fue: {0}",cantidad);
Console.WriteLine("Precio normal: ${0}",subtotal);
Console.WriteLine("Con descuento : ${0}",descuento);
Console.WriteLine("Total:${0}",total);