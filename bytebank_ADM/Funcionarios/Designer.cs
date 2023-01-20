using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }
        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
    
}
