namespace ClassesObjetos
{
    public  class Conta
    {
        public decimal Saldo = 0;
        public void Depositar(decimal valor)
        {
            Saldo += valor; //saldo = saldo + valor
            Console.WriteLine($"Saldo Atualizado: {Saldo:C}");
        }
    }
}
