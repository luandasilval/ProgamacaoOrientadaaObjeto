
namespace ClassesObjetos
{
    public class Produto
    {
        public string? Nome { get; set; } // Getters e setters
        public decimal Preco { get; set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - R${Preco:F2}");
        }
    }
}