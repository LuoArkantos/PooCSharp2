using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; set; }

        public abstract double GetBonificacao(); //Com a palavra virtual, o método pode ser reescrito por uma subclasse (classe herdeira) / com a palavra ABSTRACT, o item se torna apenas um modelo, uma referencia que DEVE ser criada nos herdeiros. Ela não recebe valores, mas exige que os herdeiros usem. Abstract seleciona o modo de como deve ser executado o item no herdeiro Ex: (public abstract DOUBLE GetBonificacao) Ou Seja.. Não tem Implementação, apenas DEFICINICAO DO METODO

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionarios++;
            //Console.WriteLine("Criando um funcionario");
        }

        public abstract void AumentarSalario();
    }
}
