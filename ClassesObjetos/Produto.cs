
namespace ClassesObjetos
{
    public class Produto
    {
        public string? Nome { get; set; } // Getters e setters
        public decimal Preco { get; private set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - R${Preco:F2}");
        }

        public void AlterarPreco(decimal NovoPreco)
        {
            Preco = NovoPreco;
        }
    }
}
