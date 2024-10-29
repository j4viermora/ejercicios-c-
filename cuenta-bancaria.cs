using System;

class Cuenta
{
    private string titular { get; set; }
    private decimal cantidad { get; set; }

    public Cuenta(string titular, decimal cantidad)
    {
        this.titular = titular;
        this.cantidad = cantidad;
    }

    public void Depositar(decimal monto)
    {
        cantidad += monto;
    }
    public void Retirar(decimal monto)
    {
      if (monto > this.cantidad){
        
        cantidad = 0;
        
      }  
      else{
        cantidad -= monto;
      }
      

    }

    public string GetTitular()
    {
        return this.titular;
    }

    public decimal GetCantidad()
    {
        return this.cantidad;
    }

}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hola dime le nombre del titular");
        string inputTitular = Console.ReadLine();
        decimal montoPorDefecto = 100;
        Cuenta miInstanciaDeCuenta = new Cuenta(inputTitular, montoPorDefecto);
        Console.WriteLine("El titular de la cuenta es: " + miInstanciaDeCuenta.GetTitular() + " y su saldo es: " + miInstanciaDeCuenta.GetCantidad());
        Console.WriteLine("Desea Retirar (type R) O Depositar(type D)");
        string tipoDeOperacion = Console.ReadLine();
        if (tipoDeOperacion.ToLower() == "r")
        {
            Console.WriteLine("Cuanto desea retirar");
            decimal montoARetirar = Convert.ToDecimal(Console.ReadLine());
            miInstanciaDeCuenta.Retirar(montoARetirar);
            Console.WriteLine("#### Has retirado " + montoARetirar + " tu saldo actual es " + miInstanciaDeCuenta.GetCantidad() + " ######");
        }
        
        if(tipoDeOperacion.ToLower()== "d"){
          Console.WriteLine("cuantos desea depositar");
          decimal montoADepositar = Convert.ToDecimal(Console.ReadLine());
          miInstanciaDeCuenta.Depositar(montoADepositar);
          Console.WriteLine("#### Has depositado " + montoADepositar + " tu saldo actual es " + miInstanciaDeCuenta.GetCantidad() + " ######");
        }
    }
}