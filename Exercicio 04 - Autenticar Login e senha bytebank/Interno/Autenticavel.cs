using Exercicio_04___Autenticar_Login_e_senha_bytebank.Pessoal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04___Autenticar_Login_e_senha_bytebank.Interno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Autenticavel(string cpf, double salario) : base (cpf, salario)
        {

        }
        public abstract bool Autenticar(string login, string senha);
    }
}
