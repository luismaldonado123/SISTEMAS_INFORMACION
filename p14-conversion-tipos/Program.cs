// Conversión entre tipos de datos en C#
// Conversión implicita: de pequeño a grande
int var1 = 9;
double var2 = var1; // int a double
float var3 = 123456.789f;
double var4 = var3; // float a double
Console.Clear();
Console.WriteLine($"Implicita de int a double : {var1} -- {var2}");
Console.WriteLine($"Implicita de float a double : {var3} -- {var4}\n");
// Conversiones explicitas : de grande a pequeño
double var5 = 123232.3433;
decimal var6 = 23124214124213412421342134.234124231m;
Console.WriteLine($"Manual de double a int : {var5} -- { (int) var5 } ");
Console.WriteLine($"Manual de double a int : {var5} -- { Convert.ToInt32(var5) }");
Console.WriteLine($"Manual de double a float : {var5} -- { Convert.ToSingle(var5) }");
Console.WriteLine($"Manual de decimal a double : {var6} -- { Convert.ToDouble(var6) }");
Console.WriteLine($"Manual de decimal a string : {var6} -- { Convert.ToString(var6) }");