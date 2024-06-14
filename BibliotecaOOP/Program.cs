namespace BibliotecaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            while (true)
            {
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Listar livros");
                Console.WriteLine("3. Buscar livro por ISBN");
                Console.WriteLine("4. Registrar empréstimo");
                Console.WriteLine("5. Registrar devolução");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        BuscarLivro(biblioteca);
                        break;
                    case 4:
                        RegistrarEmprestimo(biblioteca);
                        break;
                    case 5:
                        RegistrarDevolucao(biblioteca);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            static void AdicionarLivro(Biblioteca biblioteca)
            {
                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Livro livro = new Livro { Titulo = titulo, Autor = autor, ISBN = isbn };
                biblioteca.AdicionarLivro(livro);
            }

            static void BuscarLivro(Biblioteca biblioteca)
            {
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorISBN(isbn);
                if (livro != null)
                {
                    livro.ExibirDetalhes();
                }
                else
                {
                    Console.WriteLine("Livro não encontrado.");
                }
            }

            static void RegistrarEmprestimo(Biblioteca biblioteca)
            {
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                biblioteca.RegistrarEmprestimo(isbn);
            }

            static void RegistrarDevolucao(Biblioteca biblioteca)
            {
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                biblioteca.RegistrarDevolucao(isbn);
            }

        }
    }
}
