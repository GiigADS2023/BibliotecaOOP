using BibliotecaOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaOOP
{
    public class Livro
    {
        public string Titulo {  get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public bool Disponivel { get; private set; }

        // Exibir as informações do livro
        public void ExibirDetalhes()
        {
            //  "{}" são substituídas pelos valores das variáveis correspondentes no momento da execução
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Dispnível: {Disponivel}");
        }

        // Marca o livro como não disponível
        public void Emprestar()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine("Livro emprestado com sucesso.");
            } else
            {
                Console.WriteLine("Livro não disponível no momento.");
            }
        }

        // Marca o livro como disponível
        public void Devolver()
        {
            Disponivel = true;
            Console.WriteLine("Livro devolvido com sucesso.");
        }
    }
}


