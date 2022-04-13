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
     VerificarValor(valor);
     VerificarSaldo(valor);
     Saldo = Saldo - valor;
 }

 public void Depositar(double valor)
 {
     VerificarValor(valor);
     Saldo = Saldo + valor;
 }

 public void Transferir(double valor, Conta conta)
 {
    Sacar(valor);
    conta.Depositar(valor);
 }

 private void VerificarValor(double valor)
 {
    if(valor <= 0)
     throw new ArgumentException("O valor deve ser maior que 0.");
 }

 private void VerificarSaldo(double valor)
 {
    if(valor > Saldo)
     throw new ArgumentException("Saldo insuficiente.");
 }
}