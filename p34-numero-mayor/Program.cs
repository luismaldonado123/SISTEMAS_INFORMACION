using System;
// programa que, en base a tres numeros, verifica cual es el mayor
Console.WriteLine("hey, bienvenido al programa que en base a 3 numeros te decimos cual es el mayor");
int numero1=0,numero2=0,numero3=0,maximo;
Console.WriteLine("dame el primer numero:");
numero1= int.Parse(Console.ReadLine());
Console.WriteLine("dame el segundo numero:");
numero2= int.Parse(Console.ReadLine());
Console.WriteLine("dame el teecer numero:");
numero3= int.Parse(Console.ReadLine());
if(numero1==numero2 && numero2 == numero3){
      Console.WriteLine("son iguales");
      return;
 }if(numero1 > numero2){
    maximo = numero1;
    }else{
         maximo = numero2;
    }
    if(numero3 > maximo){
       maximo = numero3; 
    }
Console.WriteLine("El numero mayor es : {0}",maximo);