using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public bool Login(Autenticavel funcionario, string senha) // Vai pegar o nome do Diretor e a Senha atribuida. Se a senha atribuida for direfente da senha chamada ao chamar sistema.Login, o acesso é negado
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas Vindas ao Sitema");
                return true;
            }
            else
            {
                Console.WriteLine("Acesso Negado");
                return false;
            }
        }
        /*public bool Login(GerenteDeContas funcionario, string senha) // Vai pegar o nome do Gerente de Contas e a Senha atribuida. Se a senha atribuida for direfente da senha chamada ao chamar sistema.Login, o acesso é negado
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas Vindas ao Sitema");
                return true;
            }
            else
            {
                Console.WriteLine("Acesso Negado");
                return false;
            }
        }*/
    }
}
