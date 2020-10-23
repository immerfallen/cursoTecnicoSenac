using System;

namespace confirmaPresenca
{
    class Program
    {


        static void Main(string[] args)
        {
            ListaConvidados listagem = new ListaConvidados();

            string comando;
            string confirm;
            bool confirmaPresenca = false;


            Console.WriteLine("Este é o programa para confirmação de presença na minha festa.");
            do
            {
                Console.WriteLine("Gostaria de incluir novo convidado? SIM; NÃO");
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "SIM":
                        Console.WriteLine("Digite seu nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite sua idade:");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu telefone");
                        int telefone = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Confirma presença? SIM  , NAO ");
                            confirm = Console.ReadLine();
                            if (confirm == "SIM")
                            {
                                confirmaPresenca = true;
                            }
                            else if (confirm == "NAO")
                            {
                                confirmaPresenca = false;
                            }

                        } while (confirm != "SIM" && confirm != "NAO");



                        if (listagem.incluirConvidado(new Convidado(nome, idade, telefone, confirmaPresenca)) == true)
                        {
                            Console.WriteLine("Convidado confirmado.");
                        }
                        else
                        {
                            Console.WriteLine("Convidado não incluído.");
                        }

                        break;
                    case "NAO":
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;


                }
            } while (comando != "NAO");
            Console.WriteLine("Dados inseridos foram:");
            listagem.MostraDados();

        }
    }
}


