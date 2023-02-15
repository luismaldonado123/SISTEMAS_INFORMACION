// programa que envia un saludo a la pantalla
string amigo = "juan";
string hermano = "pablo";
Console.WriteLine(amigo);
amigo = "Miguel";
Console.WriteLine("Hola "+amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo es {amigo} mi hermano es {hermano}\n");
Console.WriteLine("Nombres con mayusculas:");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");
