Escuela escuela = new Escuela("universidad del bajio","Luis Maldonado","Lopez Velarde 145, Zacatecas");

escuela.AgregarProfesor(new Profesor(nombre:"Jose Diaz", fechaing:DateTime.Parse("1/1/2018"), grupo:"1A", materia:"Fisica", salario:1200));
escuela.AgregarProfesor(new Profesor(nombre:"Maria Perez", fechaing:DateTime.Parse("10/2/2016"), grupo:"2A", materia:"Algebra", salario:3400));
escuela.AgregarProfesor(new Profesor(nombre:"Claudia Sid", fechaing:DateTime.Parse("1/4/2019"), grupo:"4B", materia:"Calculo", salario:3800));
escuela.AgregarProfesor(new Profesor(nombre:"Carlos Lopez", fechaing:DateTime.Parse("10/3/2016"), grupo:"8A", materia:"Química", salario:1000));
escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Fatima Soto", edad:23, fechaing:DateTime.Parse("1/1/2019"), becado:true, califs:new List<int> {7,7,7}));
escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Damian Diaz", edad:25, fechaing:DateTime.Parse("1/1/2016"), becado:false, califs:new List<int> {8,8,8}));
escuela.Profesores[0].AgregarAlumno(new Alumno( nombre:"Alicia Soto", edad:23, fechaing:DateTime.Parse("1/1/2018"), becado:true, califs:new List<int> {6,6,6}));
escuela.Profesores[1].AgregarAlumno(new Alumno( nombre:"Maria Ochoa", edad:20, fechaing:DateTime.Parse("1/10/2018"), becado:true, califs:new List<int> {9,9,9}));
escuela.Profesores[1].AgregarAlumno(new Alumno( nombre:"Carlos Diaz", edad:23, fechaing:DateTime.Parse("1/10/2018"), becado:false, califs:new List<int> {8,8,8}));
escuela.Profesores[2].AgregarAlumno(new Alumno( nombre:"Jose Ochoa", edad:19, fechaing:DateTime.Parse("1/10/2016"), becado:false, califs:new List<int> {6,6,6}));

Console.WriteLine("\nReporte general de la escuela:\n");
Console.WriteLine(escuela.ToString());

Console.WriteLine(">>Profesores\n");

foreach(Profesor p in escuela.Profesores)
        Console.WriteLine(p.ToString());
Console.WriteLine("\n>>> Alumnos por profesor:");
foreach(Profesor p in escuela.Profesores){
    Console.WriteLine($"\n> Nombre: {p.Nombre}, Grupo: {p.Grupo}\n");
    if(p.Alumnos.Count!=0){
        p.Alumnos.ForEach(a=>Console.WriteLine(a.ToString()));
    }else Console.WriteLine("No tiene alumnos aun");
}        

        