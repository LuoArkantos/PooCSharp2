using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_01___Operacoes_Matematicas.Operacoes;

namespace Exercicio_01___Operacoes_Matematicas.Utilitario
{
    public class SistemaDeCalculo
    {
        public Adicao Soma { get; private set; }
        public Subtracao Subtracao{ get; private set; }
        public Multiplicacao Multiplicacao{ get; private set; }
        public Divisao Divisao{ get; private set; }


        public SistemaDeCalculo ()
        {
            this.Soma = new Adicao();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();    
        }
    }
}
