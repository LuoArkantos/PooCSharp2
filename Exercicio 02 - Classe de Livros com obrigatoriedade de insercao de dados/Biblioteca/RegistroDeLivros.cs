using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02___Classe_de_Livros_com_obrigatoriedade_de_insercao_de_dados.Biblioteca
{
    public class RegistroDeLivros
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isbn { get; private set; }
        public int AnoPublicacao { get; set; }
        public string Estilo { get; set; }
        public int NumeroPaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public RegistroDeLivros(string titulo, string isbn) { 
            Titulo = titulo;
            Isbn = isbn;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Titulo: " + this.Titulo);
            Console.WriteLine("ISBN: " + this.Isbn);
            Console.WriteLine("Genero: " + this.Estilo);
            Console.WriteLine("N. de Paginas: " + this.NumeroPaginas);
            Console.WriteLine("Autor: " + this.Autor);
            Console.WriteLine("Ano de Publicacao: " + this.AnoPublicacao);
        }
    }
}
