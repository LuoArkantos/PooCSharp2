using Exercicio_04___Autenticar_Login_e_senha_bytebank.Interno;
using Exercicio_04___Autenticar_Login_e_senha_bytebank.Pessoal;

SistemaInterno sistema = new SistemaInterno();

Diretor marcos = new Diretor("032 123");
marcos.Nome = "Marcos Silva";
marcos.Login = "admin";
marcos.Senha = "1234";

GerenteDeContas patricia = new GerenteDeContas("451 223");
patricia.Nome = "Patricia Marciano";
patricia.Login = "adminContas";
patricia.Senha = "4321";

sistema.Login(marcos, "admin", "1234");
sistema.Login(patricia, "adminContas", "4321");