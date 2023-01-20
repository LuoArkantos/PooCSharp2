using Exercicio_01___Operacoes_Matematicas.Utilitario;

SistemaDeCalculo calcular = new SistemaDeCalculo();

Console.WriteLine("Soma");
Console.WriteLine("Igual a " + calcular.Soma.Calcular(1,5));
Console.WriteLine();
Console.WriteLine("Subtracao");
Console.WriteLine("Igual a" + calcular.Subtracao.Calcular(7,2));
Console.WriteLine();
Console.WriteLine("Multiplicacao");
Console.WriteLine("Igual a" + calcular.Multiplicacao.Calcular(3,5));
Console.WriteLine();
Console.WriteLine("Divisao");
Console.WriteLine("Igual a" + calcular.Divisao.Calcular(10,2));