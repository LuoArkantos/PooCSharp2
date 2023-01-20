using Exercicio_04___Autenticar_Login_e_senha_bytebank.Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04___Autenticar_Login_e_senha_bytebank.Pessoal
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
