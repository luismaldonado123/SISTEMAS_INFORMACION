//cuenta numeros:positivos,negativos,ceros, hasta introducir 999
int n=0,c=0,s=0,cp=0,cn=0,cc=0;
Console.Clear();
Console.WriteLine("Cuenta numeros: positivos,negativos,ceros,hasta introducir 999");
do{
  Console.Write($"Dame un numero?");
  n = int.Parse(Console.ReadLine());
  if(n!=999){
    c++;
    s+=n;
    if(n>0) cp++;
          else if(n<0) cn++;
                 else cc++;
  }  
} while (n!=999);
Console.WriteLine("\nCaptura terminada\n");
Console.WriteLine("\nResumen:");
Console.WriteLine($"Introdujiste {c} numeros");
Console.WriteLine($"La suma de los numeros es {s}");
Console.WriteLine($"Los positivos fueron {cp}");
Console.WriteLine($"Los negativos fueron {cn}");
Console.WriteLine($"Los ceros fueron {cc}");
Console.WriteLine("\nProceso terminado ...");
