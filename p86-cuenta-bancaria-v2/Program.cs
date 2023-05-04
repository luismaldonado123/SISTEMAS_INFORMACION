//control bancario
Banco mibanco = new Banco ("Ricky ricon y Asociados SA de CV","Arboledas");
Console.WriteLine("\nReporte del banco\n");
Console.WriteLine(mibanco.ToString());

mibanco.AgregarCliente(new Cliente("nadia","zamarron"));
mibanco.AgregarCliente(new Cliente("Jose manuel","delara"));
mibanco.AgregarCliente(new Cliente("violeta","calderon"));
mibanco.AgregarCliente(new Cliente("luis","maldonado"));

mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(1200,30));
mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1000,500));
mibanco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(800,40));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(3000,50));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(2000,500));
mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(1000,40));

mibanco.Clientes[0].Cuentas[0].Retira(1000);
mibanco.Clientes[1].Cuentas[0].Retira(400);
mibanco.Clientes[1].Cuentas[0].Retira(1000);
mibanco.Clientes[2].Cuentas[1].Retira(3500);

Console.WriteLine("\nReporte del banco\n");
Console.WriteLine(mibanco.ToString());
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente: {cl.ToString()} - Cuentas: {cl.Cuentas.Count}");
    foreach(CuentaBancaria cta in cl.Cuentas){
        Console.Write((cta is CuentaDeCheques)?"cheques":"ahorro");
        if(cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres();
        Console.WriteLine($"-Saldo:{cta.Saldo}");
    }
}
