using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasNotas
{
    class Aluno
    {
        // Atributos
        public double nota1, nota2;
        private string nome;
        protected string curso; // Classes herdadas podem usar

        protected void msgCurso()
        {
            Console.WriteLine("Curso: " + curso);
        }
        // Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        // Métodos
        private double Media() // Encapsulamento
        {
            return (nota1 + nota2) / 2;
        }

        public string Situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        public void Msg()
        {
            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            double media = Media();
            string situacao = Situacao(media);

            this.Nome = "Mateus Quintino";
            
            Console.WriteLine(nome + " está " +situacao + " com média " + media + ".");
        }
    }
}
