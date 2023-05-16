public class Escuela {
    public string Nombre {get; set;}
    public string Responsable {get; set;}
    public string Domicilio {get; set;}
    public List<Profesor> Profesores {get; private set;}

    public Escuela(){Profesores = new List<Profesor>();}

    public Escuela(string nombre,string encargado,string domicilio) : this() =>
    (Nombre,Responsable,Domicilio)=(nombre,encargado,domicilio);

    public void AgregarProfesor(Profesor profesor) => Profesores.Add(profesor);
    public int TotalAlumnos() {
        int c=0;
        foreach(Profesor p in Profesores)
            c+=p.Alumnos.Count;
    return c;
    }
    public int TotalBecados() {
        int c=0;
        foreach(Profesor p in Profesores)
            c+=p.TotalBecados();
    return c;
    }
    public double TotalSalario() {
        double t=0;
        foreach(Profesor p in Profesores)
            t+=p.Salario;
    return t;
    }

    public override string ToString() => ($"Nombre : {Nombre}\nEncargado: {Responsable}\nDomicilio: {Domicilio}\n");
    public string Resumen() =>
    ($"\nTotales >> Profesores: {Profesores.Count}, Salarios: {TotalSalario():C}, ") +
    ($"Alumnos : {TotalAlumnos().ToString()}, Becados: {TotalBecados().ToString()} \n" );
}