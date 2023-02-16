// Trabajando con caracteres
char c1 = 'A', c2 = 'B';
char numero = '9';
char arroba = '@';
char pesos = '\x24';
char corazon = '\u2665';
char letraw = (char)119;
char espacio = ' ';
Console.Clear();
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(numero);
Console.WriteLine(arroba);
Console.WriteLine(pesos);
Console.WriteLine(corazon);
Console.WriteLine(letraw);
Console.WriteLine();
c1++; c2++; numero--;
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(numero);
Console.WriteLine(char.IsLetter(c1)); // True
Console.WriteLine(char.IsDigit(numero)); // True
Console.WriteLine(char.IsSymbol(pesos)); // True
Console.WriteLine(char.IsAscii(corazon)); // False
Console.WriteLine(char.IsSeparator(espacio)); // True
