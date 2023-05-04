public class CuentaDeAhorro : CuentaBancaria{ //cuenta de ahorro va a heredar de cuentabancaria
    public double Interes {get; private set;}
    public CuentaDeAhorro(double cantidad,double interes) : base(cantidad) => Interes = interes;

    public void CalcularInteres() => Saldo += (Saldo*Interes);
}