using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("012 012 011", 2000);
//pedro.Nome = "Pedro Lira";

//Console.WriteLine("Colaborador: "+pedro.Nome);
//Console.WriteLine("Bonificação do funcionario: "+pedro.GetBonificacao());
//Console.WriteLine();

//Diretor roberta = new Diretor("987654321", 5000);
//roberta.Nome = "Roberta Silva";

//Console.WriteLine("Diretora: "+roberta.Nome);
//Console.WriteLine("Bonificação de Diretor: "+roberta.GetBonificacao());
//Console.WriteLine();

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);

//Console.WriteLine();
//pedro.AumentarSalario();
//roberta.AumentarSalario();
//Console.WriteLine($"Salário com aumento do Pedro: {pedro.Salario}");
//Console.WriteLine($"Salário com aumento da Roberta: {roberta.Salario}");
#endregion
CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Diretor paula = new Diretor("123 456");
    paula.Nome = "Paula Albuquerque";
    Console.WriteLine($"Salario da Diretora {paula.Nome}: R$ " + paula.Salario);

    GerenteDeContas junior = new GerenteDeContas("032 033");
    junior.Nome = "Junior Santana";
    Console.WriteLine($"Salario de Gerente de Contas {junior.Nome}: R$ "+junior.Salario);


    Designer mariana = new Designer("123 455");
    mariana.Nome = "Mariana Pendrive";
    Console.WriteLine($"Salario da Designer {mariana.Nome}: R$ " + mariana.Salario);


    Auxiliar carlos = new Auxiliar("292 394");
    carlos.Nome = "Carlos Magno";
    Console.WriteLine($"Salario do Auxiliar {carlos.Nome}: R$ " + carlos.Salario);


    gerenciador.Registrar(paula);
    gerenciador.Registrar(junior);
    gerenciador.Registrar(mariana);
    gerenciador.Registrar(carlos);

    Console.WriteLine();
    Console.WriteLine($"Bonificação + Salario de {paula.Nome}: R$ " + paula.Salario);
    Console.WriteLine($"Bonificação + Salario de {junior.Nome}: R$ " + junior.Salario);
    Console.WriteLine($"Bonificação + Salario de {mariana.Nome}: R$ " + mariana.Salario);
    Console.WriteLine($"Bonificação + Salario de {carlos.Nome}: R$ " + carlos.Salario);
    Console.WriteLine();
    Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
}

