using System;
class Program
{
    static void Main(string[] args)
    {
        // criando Lista

        // lista de Comida
      


        string[] ComidaList = new string[7];
        {
            // lista de Alimentos e Seus Valores
            ComidaList[0] = "Maça ";
            ComidaList[1] = "Pepino ";
            ComidaList[2] = "Alfalce ";
            ComidaList[3] = "Banana";
            ComidaList[4] = "Uva "; 
            ComidaList[5] = "Cover Flor ";
            ComidaList[6] = "Berinjela ";
        }
        // seleção de usuario para ver se ele quer entrar ou não
        Console.WriteLine("Digite /e se Quiser Entrar No Mercado\n");
        Console.WriteLine("Digite /f Para não entrar no Mercado");
        string comando = Console.ReadLine();



        string Selecionamento;
        string estoque;

        if (comando == "/e" == true)
        {


            while (true)
            {
                // boas Vinda do Mercado Seu Toba
                Console.WriteLine("Seja Bem Vindo ao Mercado Seu Toba");

                Console.WriteLine("Digite /estoque para ver estoque");
                estoque = Console.ReadLine();

                if (estoque == "/estoque")
                {
                    Console.WriteLine("Aqui Esta A lista E Seus Valores\n");

                    // Monstrando Os Produtos, e Criando Comando De seleção
                    Console.WriteLine(ComidaList[0] + " \n(1)");
                    Console.WriteLine(ComidaList[1] + " \n(2)");
                    Console.WriteLine(ComidaList[2] + " \n(3)");
                    Console.WriteLine(ComidaList[3] + " \n(4)");
                    Console.WriteLine(ComidaList[4] + " \n(5)");
                    Console.WriteLine(ComidaList[5] + " \n(6)");
                    Console.WriteLine(ComidaList[6] + " \n(7)");
                    // input para usuario Escolher as opeções
                    Console.WriteLine("Selecione as Opeções Númericas:");
                    Selecionamento = Console.ReadLine();

                    switch (Selecionamento)
                    {
                        case "1":
                            Console.WriteLine($"Você Escolheu {ComidaList[0]}");
                            break;
                        case "2":
                            Console.WriteLine($"Você Escolheu {ComidaList[1]}");
                            break;
                        case "3":
                            Console.WriteLine($"Você Escolheu {ComidaList[2]}");
                            break;
                        case "4":
                            Console.WriteLine($"Você Escolheu {ComidaList[3]}");
                            break;
                        case "5":
                            Console.WriteLine($"Você Escolheu {ComidaList[4]}");
                            break;
                        case "6":
                            Console.WriteLine($"Você Escolheu {ComidaList[5]}");
                                break;
                        case "7":
                            Console.WriteLine($"Você Escolheu {ComidaList[6]}");
                            break;

                        default:
                            Console.WriteLine("Seleção Invalida Tente Novamente");
                            break;
                    }
                    break;
       
                    // vou colocar Sistema de Seleção
                }

            }
            
            
        }

        

        // separação apenas para deixar mais legivel


        // comando para caso ele decidir não entrar
        else if (comando == "/f")
        {
            Console.WriteLine("Você não entrou no Mercado");
        }

        // comando para monstra Estoque
        Console.ReadLine();
        

    }
}
