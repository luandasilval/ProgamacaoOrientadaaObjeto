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



