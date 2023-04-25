//segundo parcial
int op,n=0;
const int MAX = 100;
double [] nums = new double[MAX];
double promedio=0,suma=0;
do{
    op = menu();
    switch(op){
        case 1:
        Console.WriteLine("Cuantos elementos deseas ?");
        n = int.Parse(Console.ReadLine());
        if(n > MAX){
            Console.WriteLine("NO TE PASES :( )");
        }else{
            for(int i=0; i<n; i++){
                Console.WriteLine($"Elemento[{i}] = ");
                nums[i] = double.Parse(Console.ReadLine());
                while(nums[i] < 10 || nums[i]>100){
                    Console.WriteLine("Calificacion invalida");
                    break;
                }
            }
        }
        break;
        case 2: Mostrar(nums,n); break;
        case 3:
            suma = Suma(nums,n);
            promedio = suma /nums.Length;
            Console.WriteLine($"El promedio es : {promedio}");
            for(int i=0; i<n; i++){
                Console.WriteLine($"Elemento[{i}] = ");
                nums[i] = double.Parse(Console.ReadLine());
                if(nums[i] > promedio){
                    Console.WriteLine($"Elemento[{i}]");
                }
            }    
        break;

    }
    Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
}while(op!=3);
int menu(){
    Console.Clear();
    Console.WriteLine("Leer elmentos del arreglo..            [1]");
    Console.WriteLine("Mostrar elmentos del arreglo..         [2]");
    Console.WriteLine("calcular promedio y mostrar mayores..  [3]");
    Console.WriteLine("Salir..                                [4]");
    Console.WriteLine("Elige una opcion ?");
    int op = int.Parse(Console.ReadLine());
    return op;
}
void Mostrar(double[] a, int n){
    for(int i=0; i <=n; i++){
        Console.Write($"{a[i]} ");
    }
}
double Suma(double[] a, int n){
    double suma = 0;
    for(int i=0; i<n; i++){
        suma = suma + a[i];
    }
    return suma;
}