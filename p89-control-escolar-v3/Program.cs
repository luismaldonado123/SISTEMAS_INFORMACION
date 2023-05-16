using System.Text.Json;
Escuela escuela = null;
string archivo = "escolar.json";
string jsonEscolar="";
int op;
//
void Inicializar() {
    Console.WriteLine("\n\nInicializando con datos de prueba -------------------->");
    if(escuela is null) {
        escuela = new Escuela(nombre:"Universidad Patito SA de CV", encargado:"Ing. Juan Perez", domicilio:"Av. de la Juventud 348");
        escuela.AgregarProfesor(new Profesor(nombre:"Jose Diaz", fechaing:DateTime.Parse("1/1/2018"), grupo:"1A", materia:"Fisica",salario:1200));
        escuela.AgregarProfesor(new Profesor(nombre:"Maria Perez", fechaing:DateTime.Parse("10/2/2016"), grupo:"2A", materia:"Algebra",salario:3400));
        escuela.AgregarProfesor(new Profesor(nombre:"Claudia Sid", fechaing:DateTime.Parse("1/4/2019"), grupo:"4B", materia:"Calculo",salario:3800));
        escuela.AgregarProfesor(new Profesor(nombre:"Carlos Lopez", fechaing:DateTime.Parse("10/3/2016"), grupo:"8A", materia:"Química",salario:1000));
        escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Fatima Soto", edad:23, fechaing:DateTime.Parse("1/1/2019"), becado:true,califs:new List<int> {7,7,7}));
        escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Damian Diaz", edad:25, fechaing:DateTime.Parse("1/1/2016"), becado:false,califs:new List<int> {8,8,8}));
        escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Alicia Soto", edad:23, fechaing:DateTime.Parse("1/1/2018"), becado:true,califs:new List<int> {6,6,6}));
        escuela.Profesores[1].AgregarAlumno(new Alumno( nombre:"Maria Ochoa", edad:20, fechaing:DateTime.Parse("1/10/2018"), becado:true,califs:new List<int> {9,9,9}));
        escuela.Profesores[1].AgregarAlumno(new Alumno( nombre:"Carlos Diaz", edad:23, fechaing:DateTime.Parse("1/10/2018"), becado:false,califs:new List<int> {8,8,8}));
        escuela.Profesores[2].AgregarAlumno(new Alumno( nombre:"Jose Ochoa", edad:19, fechaing:DateTime.Parse("1/10/2016"), becado:false,califs:new List<int> {6,6,6}));
Console.WriteLine("\nDatos de prueba han sido cargados ...");
    } else {Console.WriteLine("\nYa existen datos cargados ...");}
}
//
int Menu() {
    int op;
    Console.Clear();
    Console.WriteLine("--------- MENU DE OPCIONES -------------------------");
    Console.WriteLine("Reporte escolar actualizado.................... [ 1 ]");
    Console.WriteLine("Agregar profesor a la escuela.................. [ 2 ]");
    Console.WriteLine("Agregar alumno a un profesor .................. [ 3 ]");
    Console.WriteLine("Grabar los datos a un archivo.................. [ 4 ]");
    Console.WriteLine("Cargar los datos de un archivo ................ [ 5 ]");
    Console.WriteLine("Salir ......................................... [ 6 ]");
    Console.Write("Selecciona una opción ? ");
    op = int.Parse(Console.ReadLine());
return op;
}
//
do {
    op = Menu();
    switch(op) {
        case 1 : Reporte(); break;
        case 2 : AgregarProfesor(); break;
        case 3 : AgregarAlumno(); break;
        case 4 : GrabarDatos(); break;
        case 5 : CargarDatos(); break;
        case 6 : Console.WriteLine("\n..Gracias por usar el sistema..\n");break;
    }
Console.WriteLine("\n<< Presiona cualquier tecla para continuar >>");
Console.ReadLine();
} while( op!= 6);
//
void Reporte() {
    char op;
    Console.WriteLine("\n\nReporte escolar actualizado------------------------------>");
    if(escuela is not null) {
        Console.WriteLine("\n>>> Datos Generales de la Escuela:\n");
        Console.WriteLine($"{escuela.ToString()}");
        Console.WriteLine(">>> Profesores:\n");
        escuela.Profesores.ForEach(p=>Console.WriteLine(p.ToString()));
        Console.WriteLine("\n>>> Alumnos por profesor:");
    foreach(Profesor p in escuela.Profesores) {
            Console.WriteLine($"\n> Nombre: {p.Nombre}, Grupo: {p.Grupo}\n");
        if(p.Alumnos.Count!=0) {
            p.Alumnos.ForEach(a=>Console.WriteLine(a.ToString()));
            Console.WriteLine(p.Resumen());
        } else Console.WriteLine("No tiene alumnos aún");
    }
Console.WriteLine(escuela.Resumen());
    } else {
        Console.WriteLine("\nNo hay datos en memoria para reportar...");
        Console.Write("Deseas cargar los datos de prueba (S/N) ?");
        op = (Console.ReadLine()).ToUpper()[0];
    if(op=='S') Inicializar();
    }
}
//
void AgregarProfesor() {
    Profesor profesor = new Profesor();
    if(escuela is not null) {
        Console.WriteLine("\n\nAgregar profesor a la escuela..................>");
        Console.WriteLine("\nIntroduce los datos del nuevo profesor :");
        Console.Write("Nombre : "); profesor.Nombre = Console.ReadLine();
        Console.Write("Fecha Ingreso: "); profesor.FechaIng = DateTime.Parse(Console.ReadLine());
        Console.Write("Grupo : "); profesor.Grupo = Console.ReadLine();
        Console.Write("Materia : "); profesor.Materia = Console.ReadLine();
        Console.Write("Salario : "); profesor.Salario = double.Parse(Console.ReadLine());
        escuela.AgregarProfesor(profesor);
        Console.WriteLine("\nProfesor agregado ....");
        escuela.Profesores.ForEach(p=>Console.WriteLine(p.ToString()));
    } else {Console.WriteLine("\nNo hay datos en memoria para AgregarProfesor ...");}
}
//
void AgregarAlumno() {
Alumno alumno = new Alumno();
int op;
Console.WriteLine("\n\nAgregar alumno a un profesor ..................>");
if(escuela is not null) {
    if(escuela.Profesores.Count!=0) {
        for(int i=0; i<escuela.Profesores.Count; i++)
            Console.WriteLine($"{i} - {escuela.Profesores[i].Nombre}");
            Console.Write("\nElige el profesor ..: "); op = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduce los datos del nuevo alumno :\n");
            Console.WriteLine(escuela.Profesores[op].ToString());
            Console.Write("Nombre : "); alumno.Nombre = Console.ReadLine();
            Console.Write("Edad : "); alumno.Edad = int.Parse(Console.ReadLine());
            Console.Write("Fecha Ingreso : "); alumno.FechaIng = DateTime.Parse(Console.ReadLine());
            Console.Write("Becado (S/N) : "); alumno.Becado = ( (Console.ReadLine()).ToUpper()[0] == 'S' ) ? true : false ;
            Console.Write("Califs x comas: "); alumno.Califs = new List<int> (
            Console.ReadLine().Split(',').Select(Int32.Parse).ToList() );
            escuela.Profesores[op].AgregarAlumno(alumno);
            Console.WriteLine("\nAlumno agregado ....");
            escuela.Profesores[op].Alumnos.ForEach(p=>Console.WriteLine(p.ToString()));
        } else {Console.WriteLine("\nNo hay profesores para poder AgregarAlumno ...");}
} else {Console.WriteLine("\nNo hay datos en memoria para AgregarAlumno ...");}
}
//
void GrabarDatos() {
Console.WriteLine("\n\nGrabar los datos en un archivo ---------------------------->");
    if(escuela is not null) {
        jsonEscolar = JsonSerializer.Serialize(escuela);
        File.WriteAllText(archivo,jsonEscolar);
        Console.WriteLine("\nDatos escritos en el archivo"+archivo);
    } else {Console.WriteLine("\nNo hay datos en memoria para grabar ...");}
}
//
void CargarDatos() {
Console.WriteLine("\n\nCargar los datos de un archivo ------------------------->");
    if(File.Exists(archivo)) {
        jsonEscolar = File.ReadAllText("escolar.json");
        Console.WriteLine(jsonEscolar);
        escuela = new Escuela();
        escuela = JsonSerializer.Deserialize<Escuela>(jsonEscolar);
        Console.WriteLine("\nLos datos han sido cargados ..."+archivo);
    } else {Console.WriteLine("\nEl archivo de datos no existe ...");}
}
//