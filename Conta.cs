public class Conta
{
 public int Codigo { get;}
 public double Saldo { get; private set; }

 public Conta(int codigo)
 {
     Codigo = codigo;
     Saldo = 0.0;
 }

 public void Sacar(double valor)
 {
     if(valor <= 0)
     {
         throw new ArgumentException("Não foi possível sacar valor solicitado.");
     }
     Saldo = Saldo - valor;
 }

 public void Depositar(double valor)
 {
     if(valor <= 0)
     {
         throw new ArgumentException("Não foi possível depositar valor solicitado.");
     }
     Saldo = Saldo + valor;
 }

 public void Transferir(double valor, Conta conta)
 {
     if(valor <= 0)
     {
         throw new ArgumentException("Não foi possível transferir valor solicitado.");
     }
     this.Sacar(valor);
     conta.Depositar(valor);
 }

}