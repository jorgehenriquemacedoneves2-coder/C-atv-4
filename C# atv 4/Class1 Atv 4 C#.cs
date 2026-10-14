using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("   ATIVIDADE PRÁTICA DE C#");
            Console.WriteLine("=================================");
            Console.WriteLine("1 - Cadastro de Aluno");
            Console.WriteLine("2 - Cadastro de Produto");
            Console.WriteLine("3 - Cadastro de Livro");
            Console.WriteLine("4 - Cadastro de Filme");
            Console.WriteLine("5 - Cadastro de Funcionário");
            Console.WriteLine("6 - Cadastro de Veículo");
            Console.WriteLine("7 - Cadastro de Jogo");
            Console.WriteLine("8 - Cadastro de Evento");
            Console.WriteLine("9 - Perfil de Usuário");
            Console.WriteLine("10 - Cadastro de Empresa");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=================================");
            Console.Write("Escolha uma opção: ");

            // Lê a opção escolhida
            int.TryParse(Console.ReadLine(), out opcao);

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    {
                        // Exercício 1 - Cadastro de Aluno
                        Console.WriteLine("CADASTRO DE ALUNO");

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Altura: ");
                        double altura = double.Parse(Console.ReadLine());

                        Console.Write("Cidade: ");
                        string cidade = Console.ReadLine();

                        Console.Write("Está matriculado? (true/false): ");
                        bool matriculado = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO ALUNO ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Idade: " + idade);
                        Console.WriteLine("Altura: " + altura);
                        Console.WriteLine("Cidade: " + cidade);
                        Console.WriteLine("Matriculado: " + matriculado);
                        break;
                    }

                case 2:
                    {
                        // Exercício 2 - Cadastro de Produto
                        Console.WriteLine("CADASTRO DE PRODUTO");

                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Código: ");
                        int codigo = int.Parse(Console.ReadLine());

                        Console.Write("Categoria: ");
                        string categoria = Console.ReadLine();

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Quantidade em estoque: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Está disponível? (true/false): ");
                        bool disponivel = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO PRODUTO ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Código: " + codigo);
                        Console.WriteLine("Categoria: " + categoria);
                        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));
                        Console.WriteLine("Quantidade: " + quantidade);
                        Console.WriteLine("Disponível: " + disponivel);
                        break;
                    }

                case 3:
                    {
                        // Exercício 3 - Cadastro de Livro
                        Console.WriteLine("CADASTRO DE LIVRO");

                        Console.Write("Título: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();

                        Console.Write("Ano de publicação: ");
                        int ano = int.Parse(Console.ReadLine());

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Está disponível? (true/false): ");
                        bool disponivel = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO LIVRO ---");
                        Console.WriteLine("Título: " + titulo);
                        Console.WriteLine("Autor: " + autor);
                        Console.WriteLine("Ano: " + ano);
                        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));
                        Console.WriteLine("Disponível: " + disponivel);
                        break;
                    }

                case 4:
                    {
                        // Exercício 4 - Cadastro de Filme
                        Console.WriteLine("CADASTRO DE FILME");

                        Console.Write("Nome do filme: ");
                        string nome = Console.ReadLine();

                        Console.Write("Gênero: ");
                        string genero = Console.ReadLine();

                        Console.Write("Duração em minutos: ");
                        int duracao = int.Parse(Console.ReadLine());

                        Console.Write("Nota do filme: ");
                        double nota = double.Parse(Console.ReadLine());

                        Console.Write("Está em cartaz? (true/false): ");
                        bool emCartaz = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO FILME ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Gênero: " + genero);
                        Console.WriteLine("Duração: " + duracao + " minutos");
                        Console.WriteLine("Nota: " + nota);
                        Console.WriteLine("Em cartaz: " + emCartaz);
                        break;
                    }

                case 5:
                    {
                        // Exercício 5 - Cadastro de Funcionário
                        Console.WriteLine("CADASTRO DE FUNCIONÁRIO");

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Cargo: ");
                        string cargo = Console.ReadLine();

                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Salário: ");
                        double salario = double.Parse(Console.ReadLine());

                        Console.Write("Está ativo? (true/false): ");
                        bool ativo = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO FUNCIONÁRIO ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Cargo: " + cargo);
                        Console.WriteLine("Idade: " + idade);
                        Console.WriteLine("Salário: R$ " + salario.ToString("F2"));
                        Console.WriteLine("Ativo: " + ativo);
                        break;
                    }

                case 6:
                    {
                        // Exercício 6 - Cadastro de Veículo
                        Console.WriteLine("CADASTRO DE VEÍCULO");

                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();

                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine();

                        Console.Write("Ano: ");
                        int ano = int.Parse(Console.ReadLine());

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Está disponível para venda? (true/false): ");
                        bool disponivel = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO VEÍCULO ---");
                        Console.WriteLine("Marca: " + marca);
                        Console.WriteLine("Modelo: " + modelo);
                        Console.WriteLine("Ano: " + ano);
                        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));
                        Console.WriteLine("Disponível: " + disponivel);
                        break;
                    }

                case 7:
                    {
                        // Exercício 7 - Cadastro de Jogo
                        Console.WriteLine("CADASTRO DE JOGO");

                        Console.Write("Nome do jogo: ");
                        string nome = Console.ReadLine();

                        Console.Write("Plataforma: ");
                        string plataforma = Console.ReadLine();

                        Console.Write("Ano de lançamento: ");
                        int ano = int.Parse(Console.ReadLine());

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());

                        Console.Write("Está disponível? (true/false): ");
                        bool disponivel = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO JOGO ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Plataforma: " + plataforma);
                        Console.WriteLine("Ano de lançamento: " + ano);
                        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));
                        Console.WriteLine("Disponível: " + disponivel);
                        break;
                    }

                case 8:
                    {
                        // Exercício 8 - Cadastro de Evento
                        Console.WriteLine("CADASTRO DE EVENTO");

                        Console.Write("Nome do evento: ");
                        string nome = Console.ReadLine();

                        Console.Write("Local: ");
                        string local = Console.ReadLine();

                        Console.Write("Número de participantes: ");
                        int participantes = int.Parse(Console.ReadLine());

                        Console.Write("Valor do ingresso: ");
                        double ingresso = double.Parse(Console.ReadLine());

                        Console.Write("Evento confirmado? (true/false): ");
                        bool confirmado = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO EVENTO ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("Local: " + local);
                        Console.WriteLine("Participantes: " + participantes);
                        Console.WriteLine("Ingresso: R$ " + ingresso.ToString("F2"));
                        Console.WriteLine("Confirmado: " + confirmado);
                        break;
                    }

                case 9:
                    {
                        // Exercício 9 - Perfil de Usuário
                        Console.WriteLine("PERFIL DE USUÁRIO");

                        Console.Write("Nome de usuário: ");
                        string usuario = Console.ReadLine();

                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.Write("Nota do perfil: ");
                        double nota = double.Parse(Console.ReadLine());

                        Console.Write("E-mail: ");
                        string email = Console.ReadLine();

                        Console.Write("Perfil ativo? (true/false): ");
                        bool ativo = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DO PERFIL ---");
                        Console.WriteLine("Usuário: " + usuario);
                        Console.WriteLine("Idade: " + idade);
                        Console.WriteLine("Nota: " + nota);
                        Console.WriteLine("E-mail: " + email);
                        Console.WriteLine("Ativo: " + ativo);
                        break;
                    }

                case 10:
                    {
                        // Exercício 10 - Cadastro de Empresa
                        Console.WriteLine("CADASTRO DE EMPRESA");

                        Console.Write("Nome da empresa: ");
                        string nome = Console.ReadLine();

                        Console.Write("CNPJ: ");
                        string cnpj = Console.ReadLine();

                        Console.Write("Número de funcionários: ");
                        int funcionarios = int.Parse(Console.ReadLine());

                        Console.Write("Faturamento mensal: ");
                        double faturamento = double.Parse(Console.ReadLine());

                        Console.Write("Empresa ativa? (true/false): ");
                        bool ativa = bool.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- DADOS DA EMPRESA ---");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("CNPJ: " + cnpj);
                        Console.WriteLine("Funcionários: " + funcionarios);
                        Console.WriteLine("Faturamento: R$ " + faturamento.ToString("F2"));
                        Console.WriteLine("Ativa: " + ativa);
                        break;
                    }

                case 0:
                    Console.WriteLine("Programa encerrado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Escolha uma opção de 0 a 10.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);

        Console.WriteLine("\nObrigado por utilizar o programa!");
        Console.ReadKey();
    }
}