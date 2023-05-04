public class CuentaBancaria{

  public double Saldo {get; protected set;} //protected para que pueda accederse desde clase derivada.

  public CuentaBancaria(double cantidad) => Saldo = cantidad;

  public void Deposita(double cantidad) => Saldo += cantidad;

  public virtual bool Retira(double cantidad){//virtual para que pueda ser sobrecargado a la clase derivada.

       if(Saldo>=cantidad){
           Saldo-=cantidad;
         return true;
     }else return false;

    }
}