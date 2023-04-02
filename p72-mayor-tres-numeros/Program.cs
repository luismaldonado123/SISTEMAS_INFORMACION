// Calcula el mayor de tres números usando una función
float mayor(float n1,float n2,float n3) {
    float may=0;
    if(n1>n2&&n1>n3) may=n1;
    else if(n2>n1&&n2>n3) may=n2;
    else if(n3>n1&&n3>n2) may=n3;
    return may;
}
string[] nums;
float n1,n2,n3,may;
Console.Clear();
Console.WriteLine("Dame tres numeros enteros separados por espacio:");
nums = Console.ReadLine().Split();
n1=int.Parse(nums[0]); n2=int.Parse(nums[1]); n3=int.Parse(nums[2]);
may = mayor(n1,n2,n3);
Console.WriteLine($"El mayor de los tres es : {may}");