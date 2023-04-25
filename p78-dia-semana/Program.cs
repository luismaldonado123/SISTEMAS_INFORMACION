//programa que obtenga el dia de la semana
int numero = GetNum();
string diasemana = GetWeek(numero);
Console.WriteLine("el dia de la semana es : "+diasemana);
int GetNum(){
    int numero;
    do{
        Console.WriteLine("Ingresa un numero entre 1 y 7:");
        numero = int.Parse(Console.ReadLine());
    }while(numero < 1 || numero > 7);
    return numero;
}
string GetWeek(int numero){
       string[] DSem = {"Lunes", "Martes","Miercoles","Jueves","Viernes","Sabado","domingo"};
       return DSem[numero-1];
}
