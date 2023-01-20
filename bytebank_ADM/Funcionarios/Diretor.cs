using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:Autenticavel
    {
        
        public Diretor(string cpf):base(cpf, 5000)
        {

        }
        public override double GetBonificacao() // com Override, o método pode reescrever o VIRTUAL da classe base.
        {
            return this.Salario *= 0.5; // palavra BASE chama o método da classe base, a superclasse. Se não colocar o "Base.", vai dar stack overflow pq o programa vai pegar a classe atual, chamando a si mesma e empilhando chamadas.
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
