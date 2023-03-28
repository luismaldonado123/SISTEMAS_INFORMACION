// Conversion de temperaturas usando funciones
float Farenheit(float t) {
      return (t*9/5)+32;
}
float Celcius(float t) {
      return (t-32)*5/9;
}
int op;
float temp, res;
Console.Clear();
Console.Write("[1] farenheit\n[2] celcius\nElige ? ");
op = int.Parse(Console.ReadLine());
Console.Write("Dame la temperatura ? ");
temp = float.Parse(Console.ReadLine());
if(op==1) {
    res = Farenheit(temp);
    Console.WriteLine($"\n{temp} grados celcius equivale a {res} grandos farenheit ..");
}
else if(op==2) {
     res = Celcius(temp);
     Console.WriteLine($"\n{temp} grados farenheit equivale a {res} grandos celcius ..");
}
else Console.WriteLine("Opción inválida");
