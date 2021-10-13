using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instânciar objeto
            Aluno aluno = new Aluno();
            aluno.Nome = "Mateus Quintino, Dev de C#"; // Usando Set
            Console.WriteLine(aluno.Nome);

            // Chamando um Construtor
            Curso curso = new Curso("Análise e Desenvolvimento de Sistemas",2);
            
            Console.ReadLine();
        }
    }
}
