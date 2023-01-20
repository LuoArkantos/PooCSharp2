using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01___Operacoes_Matematicas.Operacoes
{
    public class Divisao
    {
        public double Calcular(double dividendo, double divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine($"{dividendo} / {divisor}");
                return dividendo / divisor;
            }
            
        }
    }
}
