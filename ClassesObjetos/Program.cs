using System.ComponentModel;
using ClassesObjetos;

int numero1 = 5;
int numero2 = 10;

Produto p1 = new Produto(); //instanciando um objeto da classe produto
p1.Nome = "Notebook";
p1.AlterarPreco(3500m);
//p1.Preco = 3500m;
p1.Exibir();

Produto p2 = new Produto(); //instanciando um objeto da classe produto
p2.Nome = "Mouse";
p2.AlterarPreco(100m);
p2.Exibir();

//*classes e métodos static
int resultado = Calculadora.Somar(10, 20);
Console.WriteLine($"Resultado: {resultado}");

Conta conta_corrente = new Conta();
Conta conta_poupanca = new Conta();

conta_corrente.Depositar(100m);
conta_poupanca.Depositar(50m);

Console.WriteLine(Math.Round(10.567, 2)); //arredonda
Console.WriteLine(DateTime.Now);

Pessoa pessoa1 = new Pessoa();
Console.WriteLine($"Nome: {pessoa1.Nome}");
Console.WriteLine($"Idade: {pessoa1.Idade}");

Pessoa pessoa2 = new Pessoa("João", 30);
Console.WriteLine($"Nome: {pessoa2.Nome}");
Console.WriteLine($"Idade: {pessoa2.Idade}");

string nome = "Samuel";
Produto p3 = new Produto
{
    Nome = "PS5",
};