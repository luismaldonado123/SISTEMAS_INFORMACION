   int op,pos,n=0;
   double nb;
   const int MAX =100;
   double [] nums = new double[MAX];
   double suma = 0,promedio=0;
   do{
    op = menu();
    switch(op){
        case 1 :
             Console.WriteLine("Cuantos elementos deseas ?");
             n = int.Parse(Console.ReadLine());
             if(n > MAX){
                Console.WriteLine("no te pases :( )");
             }else{
                for(int i=0; i<n; i++){
                    Console.WriteLine($"Elmento[{i+1}]=");
                    nums[i] = double.Parse(Console.ReadLine());
                }
             }
             break;
        case 2 : Mostrar(nums,n); break;
        case 3 : 
             suma = Suma(nums,n);
             promedio = suma/nums.Length;
             Console.WriteLine($"\n la suma es {suma}");
             Console.WriteLine($"\n El promedio es {promedio}");
             break;
        case 4 :
             Console.WriteLine($"\nEl mayor es : {Mayor(nums,n)}");     
             Console.WriteLine($"\nEl menor es : {Menor(nums,n)}");
             break;
        case 5 :
             Console.WriteLine("\nQue elemento buscas ?");
             nb = double.Parse(Console.ReadLine());
             pos = Buscar(nums,nb,n);
             if(pos==-1) Console.WriteLine("Elemento no encontrado");    
             else Console.WriteLine($"Encontrado en la posicion {pos}");
             break; 
    }
    Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
   }while(op!=6);
int menu(){
    Console.Clear();
    Console.WriteLine("leer elementos en el arreglo..                [1]");
    Console.WriteLine("mostrar elementos en el arreglo..             [2]");
    Console.WriteLine("calcular y mostrar la suma y promedio..       [3]");
    Console.WriteLine("calcular y mostrar el elemento mayor y menor..[4]");
    Console.WriteLine("buscar elementos en el arreglo..              [5]");
    Console.WriteLine("Salir                                         [6]");
    Console.WriteLine("Elige una opcion ?");
    int op = int.Parse(Console.ReadLine());
    return op;
}
void Mostrar(double[] a, int n){
    for(int i=0; i<=n; i++){
       Console.WriteLine($"{a[i]} ");
    }  
}
double Suma(double[] a, int n){
    double suma =0;
    for(int i=0; i<n; i++)
        suma = suma + a[i];
    return suma;
}
double Mayor(double[] a,int n){
    double may =a[0];
    for(int i=0; i<n; i++)
        if(a[i] > may)
          may = a[i];
    return may;
}
double Menor(double[] a,int n){
    double men =a[0];
    for(int i=0; i<n; i++)
        if(a[i] < men)
          men = a[i];
    return men;
}
int Buscar(double[] a, double nb,int n){
    int pos =-1;
    for(int i=0; i<n; i++)
       if(a[i] == nb)
         pos = 1;
    return pos;     
}
