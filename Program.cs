//Programa que con funciones pida 4 numeros y devuelva el menor
float menor(float n1, float n2, float n3, float n4){
     float men = 0;
     if(n1 < n2 && n1 < n3 && n1 < n4) men = n1;
       else if (n2 < n1 && n2 <3 && n3 < n4) men = n2;
       else if(n3 < n1 && n3 < n2 && n3 < n4) men = n3;
       else if(n4 < n1 && n4 < n2 && n4 < n3) men = n4;
    return men;   
}
string[] nums;
float n1,n2,n3,n4,men;
Console.Clear();
Console.WriteLine("Dame los 4 numeros enteros separados por espacio :");
nums = Console.ReadLine().Split();
n1 = int.Parse(nums[0]); n2 = int.Parse(nums[1]); n3 = int.Parse(nums[2]); n4 = int.Parse(nums[3]);
men = menor(n1,n2,n3,n4);
Console.WriteLine($"El menor de los 4 numeros es : {men}");