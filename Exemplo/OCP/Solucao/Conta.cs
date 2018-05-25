namespace Exemplo.OCP.Solucao
{
    public abstract class Conta
    {
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public decimal Saldo { get; protected set; }
        public string Titular { get; private set; }
        public abstract void Sacar(decimal valor);
    }
}
