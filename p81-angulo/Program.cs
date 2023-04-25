//palabra segun nangulo
Console.Clear();
int angulo;
Console.WriteLine("ingresa un angulo entre 0 y 360 grados");
angulo = int.Parse(Console.ReadLine());
string TipoanguloV = Tipoangulo(angulo);
Console.WriteLine($"el angulo {angulo} es {TipoanguloV}");

string Tipoangulo(int angulo){
    if (angulo < 90)
        return "angulo agudo";
    else if(angulo == 90)
        return "angulo recto";
    else if(angulo > 90 && angulo < 180)
        return "angulo obtuso";
    else if(angulo == 180)
        return "angulo llano";
    else if(angulo > 180 && angulo < 360)
        return "angulo concavo";
    else
        return "opcion invalida";                 
}
