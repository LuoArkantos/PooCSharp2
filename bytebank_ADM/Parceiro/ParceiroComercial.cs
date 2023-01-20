using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Parceiro
{
    public class ParceiroComercial
    {
        public void Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
