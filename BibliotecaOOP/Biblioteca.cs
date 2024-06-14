using BibliotecaOOP;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaOOP
{
    public class Biblioteca
    {
        public List<Livro> Livros { get; private set; } = new List<Livro>();

        // Adiciona um livro à biblioteca
        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
            Console.WriteLine("Livro adicionado com sucesso.");
        }

        // Lista todos os livros da biblioteca
        public void ListarLivros()
        {
            foreach (var livro in Livros)
            {
                livro.ExibirDetalhes();
            }
        }

        // Busca um livro pelo ISBN e retorna o livro encontrado
        public Livro BuscarLivroPorISBN(string isbn)
        {
            return Livros.Find(l => l.ISBN == isbn);
        }

        // Registra o empréstimo de um livro
        public void RegistrarEmprestimo(string isbn)
        {
            var livro = BuscarLivroPorISBN(isbn);
            if (livro != null)
            {
                livro.Emprestar();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        // Registra a devolução de um livro
        public void RegistrarDevolucao(string isbn)
        {
            var livro = BuscarLivroPorISBN(isbn);
            if (livro != null)
            {
                livro.Devolver();
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

    }
}

