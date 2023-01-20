using Exercicio_02___Classe_de_Livros_com_obrigatoriedade_de_insercao_de_dados.Biblioteca;

RegistroDeLivros livro1 = new RegistroDeLivros("A Volta dos que não foram", "032A");
livro1.NumeroPaginas = 500;
livro1.AnoPublicacao = 1956;
livro1.Estilo = "Suspense";
livro1.Autor = "Macaco Louco";
livro1.PaisDePublicacao = "Majaika";

livro1.MostrarDados();