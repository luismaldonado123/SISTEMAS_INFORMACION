// Trabajando con constantes
const double DESCUENTO = 0.10;
const int VELOCIDADLUZ = 30000;
const float TASA = 0.5f;
const byte SEPARADOR = 254;
const sbyte LITERAL = 0x64;
Console.Clear();
Console.WriteLine("La constantes son:\n");
Console.WriteLine("descuento x 2 : {0}", 2 * DESCUENTO);
Console.WriteLine("velocidad / 2 : {0}", VELOCIDADLUZ / 2);
Console.WriteLine("tasa : {0:p}", TASA);
Console.WriteLine("separador - literal en hexadecimal : {0:x} - {1:x}", SEPARADOR, LITERAL);
Console.WriteLine("separador - literal en binario : {0} - {1}",Convert.ToString(SEPARADOR,2) , Convert.ToString(LITERAL,2) );