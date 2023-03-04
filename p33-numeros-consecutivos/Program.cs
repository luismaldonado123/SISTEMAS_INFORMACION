// dados 3 numeros enteros, verificar si son consecutivos(9,10,11) y mandar mensaje conformandolo,
//si no lo son(1,4,6) mandar mensaje de error.

Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
int num3 = int.Parse(Console.ReadLine());
    if (num2 == num1 + 1 && num3 == num2 + 1) {
            Console.WriteLine("Los números {0}, {1}, {2} son consecutivos.", num1, num2, num3);
    } else { Console.WriteLine("Los números {0}, {1}, {2} no son consecutivos.", num1, num2, num3); }
