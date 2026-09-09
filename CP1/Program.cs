using CP1;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<FuncionarioTransporte> listaFuncionarios = new List<FuncionarioTransporte>();
            int opcao = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Logística para Transportadora ===");
                Console.WriteLine("1 - Cadastrar motorista de carreta");
                Console.WriteLine("2 - Cadastrar entregador de moto");
                Console.WriteLine("3 - Exibir todos os colaboradores");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string? entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-- Cadastro de motorista de carreta --");
                            Console.Write("Digite o nome: ");
                            string nomeMotorista = Console.ReadLine() ?? string.Empty;

                            Console.Write("Digite o registro: ");
                            if (!int.TryParse(Console.ReadLine(), out int registroMotorista))
                            {
                                Console.WriteLine("Registro inválido.");
                                Console.ReadKey();
                                break;
                            }

                            Console.Write("Digite a categoria da CNH: ");
                            string categoriaCNH = Console.ReadLine() ?? string.Empty;

                            listaFuncionarios.Add(new MotoristaCarreta(nomeMotorista, registroMotorista, categoriaCNH));
                            Console.WriteLine("\nMotorista de carreta cadastrado com sucesso.");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("-- Cadastro de entregador de moto --");
                            Console.Write("Digite o nome: ");
                            string nomeEntregador = Console.ReadLine() ?? string.Empty;

                            Console.Write("Digite o registro: ");
                            if (!int.TryParse(Console.ReadLine(), out int registroEntregador))
                            {
                                Console.WriteLine("Registro inválido.");
                                Console.ReadKey();
                                break;
                            }

                            Console.Write("Digite a placa do veículo: ");
                            string placaVeiculo = Console.ReadLine() ?? string.Empty;

                            listaFuncionarios.Add(new EntregadorMoto(nomeEntregador, registroEntregador, placaVeiculo));
                            Console.WriteLine("\nEntregador de moto cadastrado com sucesso.");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("-- Lista de colaboradores --");

                            if (listaFuncionarios.Count == 0)
                            {
                                Console.WriteLine("\nNenhum colaborador cadastrado.");
                            }
                            else
                            {
                                foreach (FuncionarioTransporte funcionario in listaFuncionarios)
                                {
                                    funcionario.MostrarDetalhes();
                                }
                            }

                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ReadKey();
                            break;

                        case 0:
                            Console.WriteLine("Saindo do sistema...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                    Console.ReadKey();
                }
            } while (opcao != 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            Console.WriteLine("Pressione qualquer tecla para fechar.");
            Console.ReadKey();
        }
    }
}
