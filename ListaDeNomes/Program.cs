using System;
using System.Collections.Generic;

namespace ListaDeNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            var escolha = string.Empty;


            while (escolha != "6")
            {
                Console.WriteLine("Bem-vindo a lista de nomes, por selecione uma opção abaixo:");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("1 - Adicionar um novo nome");
                Console.WriteLine("2 - Remover um nome");
                Console.WriteLine("3 - Alterar um nome");
                Console.WriteLine("4 - Pesquisar por um nome");
                Console.WriteLine("5 - Lista completa");
                Console.WriteLine("6 - Sair");
                Console.WriteLine();
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Adicionar(nomes);
                        break;
                    case "2":
                        Remover(nomes);
                        break;
                    case "3":
                        Alterar(nomes);
                        break;
                    case "4":
                        Pesquisar(nomes);
                        break;
                    case "5":
                        ListaCompleta(nomes);
                        break;
                    case "6":
                        Console.WriteLine();
                        Console.WriteLine("Obrigado por consultar nossa lista! :)");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
            }
        }

        private static void Adicionar(List<string> lista)
        {
            var nome = string.Empty;
            Console.WriteLine();
            Console.WriteLine("Por favor insira o nome que deseja adicionar:");
            nome = Console.ReadLine();

            foreach (var i in lista)
            {
                var semEspaco = i.Trim();
                var nomeSemEspaco = nome.Trim();
                if (nomeSemEspaco == semEspaco || String.IsNullOrEmpty(nomeSemEspaco))
                {
                    Console.WriteLine("Nome já consta na lista ou você inseriu algo errado.");
                    Console.WriteLine();
                    return;
                }
            }

            lista.Add(nome);
            Console.WriteLine("Nome adicionado com sucesso!");
            Console.WriteLine();
        }

        private static void Remover(List<string> lista)
        {
            var nome = string.Empty;
            Console.WriteLine();
            Console.WriteLine("Por favor insira o nome que será removido:");
            nome = Console.ReadLine();

            foreach (var i in lista)
            {
                if (nome == i)
                {
                    lista.Remove(nome);
                    Console.WriteLine("Nome removido com sucesso!");
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Nome não consta na lista");
            Console.WriteLine();
            
        }

        private static void Alterar(List<string> lista)
        {
            var nome = string.Empty;
            Console.WriteLine();
            Console.WriteLine("Por favor insira o nome que será alterado:");
            nome = Console.ReadLine();

            for (int i = 0; i < lista.Count; i++)
            {
                if (nome == lista[i])
                {
                    Console.WriteLine($"Nome encontrado '{lista[i]}', como gostaria de modificalo?");
                    var novoNome = Console.ReadLine();
                    lista[i] = novoNome;
                    Console.WriteLine("Nome alterado com sucesso");
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Nome não existe!");
            Console.WriteLine();
        }

        private static void Pesquisar(List<string> lista)
        {
            var nome = string.Empty;
            Console.WriteLine();
            Console.WriteLine("Por favor insira o nome que você procura:");
            nome = Console.ReadLine();

            foreach (var i in lista)
            {
                if (nome == i)
                {
                    Console.WriteLine($"Nome encontrado: {nome}");
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Nome não encontrado!");
            Console.WriteLine();
        }

        private static void ListaCompleta(List<string> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
