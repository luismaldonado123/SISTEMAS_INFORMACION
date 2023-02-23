// muestra el tipo de angulo segun los grados
Console.Clear();
Console.WriteLine("Muestra el tipo de angulo segun los grados\n");
Console.Write("Dame un angulo ? ");
int angulo = int.Parse(Console.ReadLine());

if(angulo < 0 || angulo>360)
    Console.WriteLine("Angulo invalido..");
else{
    if(angulo==0)
    Console.WriteLine("\nEl angulo es nulo");
    if(angulo >0 && angulo<90) 
    Console.WriteLine("\nEs agudo");
    if(angulo==90) 
    Console.WriteLine("\nEs recto");
    if(angulo>90 && angulo<180) 
    Console.WriteLine("\nEs obtuso");
    if(angulo==180) 
    Console.WriteLine("\nEs llano");
    if(angulo>180 && angulo<360) 
    Console.WriteLine("\nEs concavo");
    if(angulo==360) 
    Console.WriteLine("\nEs completo");
}
