int numero=0, carry = 0, x = 0, fiboant = 0 , z = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime los primeros n numeros de la serie de fibonacci\n");
    do {
        Console.Write("Ingresa un numero? ");
        numero = int.Parse(Console.ReadLine());
    } while( numero <= 0);
    do {
        z = fiboant;
        fiboant = x;
        x = fiboant + z;
        Console.Write($"{fiboant,5}\t ");
        if(x == 0)
         x++;
         carry++;
    } while(carry < numero);
    carry = x = fiboant = z = 0;
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");