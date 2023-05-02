public class Cliente{
    public string Nombre {get;set;}
    public string Apeido {get;set;}
    public CuentaBancaria Cuenta {get;set;}
    public Cliente(string nombre, string apeido) => (Nombre,Apeido) = (nombre,apeido);

    public override string ToString() => $"{Nombre},{Apeido}";
}