public class Empleado{
    public string Nombre {get;set;}
    public int Edad {get;set;}

    public Empleado() {}
    public Empleado(string nombre) => Nombre = nombre;
    public Empleado(string nombre, int edad) => (Nombre,Edad) = (nombre,edad);

    public void ImprimirDatos(){
        Console.WriteLine($"nombre {Nombre}");
        Console.WriteLine($"edad {Edad}");
    }

}