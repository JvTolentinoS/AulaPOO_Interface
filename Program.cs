using System;
using AulaPOO_Interface.Classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            Carrinho carrinho = new Carrinho();
            Produto p1 = new Produto();
            p1.Codigo = 321;
            p1.Nome = "Exemplo 1";
            p1.Preco = 1000;

            Produto p2 = new Produto();
            p2.Codigo = 321;
            p2.Nome = "Exemplo 2";
            p2.Preco = 2000;
            do{
                Console.WriteLine($"Deseja remover, cadastrar ou alterar um produto?");
                Console.WriteLine($"1 - Cadastrar");
                Console.WriteLine($"2 - Alterar");
                Console.WriteLine($"3 - Remover");
                Console.WriteLine($"4 - Listar");
                
                
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        do{
                                Console.WriteLine($"Deseja cadastrar qual produto?");
                                Console.WriteLine($"1 - {p1.Nome}");
                                Console.WriteLine($"2 - {p2.Nome}");
                                Console.WriteLine($"0 - Sair");
                                resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 1:
                                carrinho.Cadastrar(p1);
                                    break;
                                case 2:
                                carrinho.Cadastrar(p2);
                                    break;
                            }
                        }while(resposta != 0);
                    break;
                    case 2:
                        do{
                                Console.WriteLine($"Deseja alterar qual produto?");
                                Console.WriteLine($"1 - {p1.Nome}");
                                Console.WriteLine($"2 - {p2.Nome}");
                                Console.WriteLine($"0 - Sair");
                                resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 1:
                                carrinho.Alterar(p2.Codigo , p1);
                                    break;
                                case 2:
                                carrinho.Alterar(p1.Codigo , p2);
                                    break;
                                default:
                                    break;
                            }
                        }while(resposta != 0);
                    break;
                    case 3:
                        do{
                                Console.WriteLine($"Deseja remover qual produto?");
                                Console.WriteLine($"1 - {p1.Nome}");
                                Console.WriteLine($"2 - {p2.Nome}");
                                Console.WriteLine($"0 - Sair");
                                resposta = int.Parse(Console.ReadLine());
                            switch (resposta)
                            {
                                case 1:
                                carrinho.Deletar(p1);
                                    break;
                                case 2:
                                carrinho.Deletar(p2);
                                    break;
                                default:
                                    break;
                            }
                            
                        }while(resposta != 0);
                    break;
                    case 4: 
                        carrinho.Listar();
                    break;
                    default:
                        break;
                }
                
            }while(resposta != 0);
        }
    }
}
