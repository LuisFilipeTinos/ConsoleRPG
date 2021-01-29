using System;

namespace TesteRPGAntigoDeConsole.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------RPG DOS GAROTOS MENINOS------------------------");
            char resposta = 'n';

            while (resposta == 'n')
            {
                Console.WriteLine("DIGITE O NOME DO SEU PERSONAGEM: ");
                string nome = Console.ReadLine();
                Console.WriteLine("DIGITE A CLASSE DO SEU PERSONAGEM: ");
                string classe = Console.ReadLine();
                Console.WriteLine("DIGITE SEU ARMAMENTO: ");
                string arma = Console.ReadLine();
                Personagem per = new Personagem(nome, classe, arma);

                Console.WriteLine();

                Console.WriteLine("OLÁ, JOGADOR! SEUS DADOS ESTÃO CORRETOS? (s/n)");
                Console.WriteLine();
                Console.WriteLine("NOME: " + per.Nome + " CLASSE: " + per.Classe + " ARMA: " + per.Arma);
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine();

                if (resposta == 's')
                {
                    Console.WriteLine("VAMOS COMEÇAR A AVENTURA!");
                }
                else
                {
                    Console.WriteLine("INSIRA SEUS DADOS NOVAMENTE");
                }
            }
            

        }
    }
}
