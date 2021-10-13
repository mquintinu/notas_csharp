using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasNotas
{
    class Curso : Aluno // Herança
    {
        private int duracao;

        //  Construtor
        public Curso(string curso, int duracao)
        {
            this.duracao = 2;
            Msg(); // chama o msg lá da classe Aluno
        }

        protected void msgDuracao()
        {
            Console.WriteLine("Duração: " + duracao);
        }

    }
}
