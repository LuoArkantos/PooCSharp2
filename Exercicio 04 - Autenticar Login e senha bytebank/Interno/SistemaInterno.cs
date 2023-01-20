using Exercicio_04___Autenticar_Login_e_senha_bytebank.Pessoal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04___Autenticar_Login_e_senha_bytebank.Interno
{
    public class SistemaInterno
    {
        public bool Login(Autenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login,senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("ACESSO LIBERADO");
                return true;
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
                return false;
            }
        } 
    }
}
