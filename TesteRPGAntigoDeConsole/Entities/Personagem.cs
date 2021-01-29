using System;
using System.Collections.Generic;
using System.Text;

namespace TesteRPGAntigoDeConsole.Entities
{
    class Personagem
    {
        public string Nome { get; private set; }

        public string Classe { get; private set; }

        public string Arma { get; private set; }



        public Personagem(string nome, string classe, string arma)
        {
            Nome = nome;
            Classe = classe;
            Arma = arma;
        }

        


    }
}
