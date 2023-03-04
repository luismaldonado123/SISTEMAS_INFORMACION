// evaluar el resultado de acuerdo a las calificaciones de un usuario
using System;
Console.WriteLine("dame tus 5 calificaciones..");
double[] calificaciones = new double[5];
double promedio=0;
for(int i=0; i < 5; i++){
    Console.WriteLine("Calificacion {0}:",i+1);
    calificaciones[i] = double.Parse(Console.ReadLine());
}
//calcular el promedio
for(int i = 0; i < 5; i++){
    promedio += calificaciones[i];
}
promedio /=5;
//evaluamos los resultados
if(promedio > 0 && promedio <=6){
    Console.WriteLine("Tu promedio es {0} Quedas reprobado! te veo el siguiente semestre", promedio);
}else if(promedio > 6 && promedio <=7){
    Console.WriteLine("Tu promedio es {0} pasas de panzazo amigo...",promedio);
}else if(promedio > 7 && promedio <=8){
    Console.WriteLine("Tu promedio es {0} muy bien, puedes mejorar",promedio);
}else if(promedio > 8 && promedio <=9){
    Console.WriteLine("Tu promedio es {0} Excelente, sigue asi",promedio);
}else if(promedio > 9 && promedio <=10){
    Console.WriteLine("Tu promedio es {0} Perfecto, tu esfuerzo valio la pena",promedio);
}else{
    Console.WriteLine("Error, vuelve a intentar");
}