Console.WriteLine("\nProbando clase cuenta bancaria");
CuentaBancaria cuenta1 = new CuentaBancaria(5000);
cuenta1.Deposita(10000);
Console.WriteLine($"El saldo es {cuenta1.Saldo}");

bool retiro = cuenta1.Retira(50);
if(retiro) Console.WriteLine($"Retiro efectuado, nuevo saldo {cuenta1.Saldo}");
else Console.WriteLine("Ni pa los cigarros tienes");

Console.WriteLine("\nProbando clase cliente");
Cliente cliente1 = new Cliente("David","Monreal");
cliente1.Cuenta = cuenta1;
Console.WriteLine($"Cliente : {cliente1.ToString()}");
Console.WriteLine($"El saldo es : {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Luis","Maldonado");
cliente2.Cuenta = new CuentaBancaria(10000000);
cliente2.Cuenta.Retira(5000);
Console.WriteLine($"Cliente : {cliente2.ToString()}");
Console.WriteLine($"El saldo es : {cliente2.Cuenta.Saldo}");

Console.WriteLine("\nProbando clase Banco");
Banco mibanco = new Banco("Banco patito SA de CV","Arboledas 124");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente("Solo vino","solo se fue");
cliente3.Cuenta = new CuentaBancaria(10001);
mibanco.AgregarCliente(cliente3);
mibanco.Clientes[0].Cuenta.Deposita(10000);
mibanco.Clientes[1].Cuenta.Deposita(1000);
mibanco.Clientes[2].Cuenta.Deposita(1231323);

Console.WriteLine("\nResumen del banco \n");
Console.WriteLine($"Banco :{mibanco.ToString()}");

foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"cliente {cl.ToString()}");
    Console.WriteLine($"saldo {cl.Cuenta.Saldo}");
}