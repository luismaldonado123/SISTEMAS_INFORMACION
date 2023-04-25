//suma multiplos
int op,inicial,final;
Console.Clear();
do{
    Console.WriteLine("Menu de opciones");
    Console.WriteLine("suma de los multiplos de 3..... [1]");
    Console.WriteLine("suma de los multiplos de 4..... [2]");
    op = int.Parse(Console.ReadLine());
    switch(op){
        case 1:
            Console.WriteLine("rango inicial ?"); inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("rango final ?"); final = int.Parse(Console.ReadLine());
            Console.WriteLine($"la suma de los multiplos de 3 entre el rango inicial {inicial} y final {final} es : {sumaM(inicial,final,3)}");
        break;
        case 2:
            Console.WriteLine("rango inicial ?"); inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("rango final ?"); final = int.Parse(Console.ReadLine());
            Console.WriteLine($"la suma de los multiplos de 4 entre el rango inicial {inicial} y final {final} es : {sumaM(inicial,final,4)}");
        break;   
    }
}while(op!=2);
int sumaM(int inicial,int final, int y){
    int suma = 0;
    for(int i=inicial; i<=final; i++){
        suma = suma + i;
    }
    return suma;
}