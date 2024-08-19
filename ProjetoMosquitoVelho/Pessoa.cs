
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Pessoa
    {
        //criando atributos ou variáveis globais privadas
        private string nome;
        private string email;
        private int idade;
        private bool alive;
       
        //criando método get e set

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }
        public bool Alive { get => alive; set => alive = value; }

        


    }
}
