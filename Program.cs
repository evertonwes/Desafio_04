using System;
using System.Collections.Generic;
using System.Globalization;

namespace Desafio_04
{
    class Program
    {
        static void Main(string[] args)

        {

            //Instancia classe Aluno
            Aluno a = new Aluno(" ", 0, 0.00);

            Console.Write("Digite a quantidade de Alunos : ");
            int n = int.Parse(Console.ReadLine());

            //Criacao Array / Vetor
            Aluno[] arrayAluno = new Aluno[n];

            //Criacao Lista
            List<Aluno> listaAlunos = new List<Aluno>();

            for (int i = 0; i < n; i++)  {
                Console.WriteLine("*-------------------------------------------------------------*");
                Console.Write("Qual o nome do Aluno: ");
                string nome =  Console.ReadLine();
                
                
                Console.Write("Qual a idade do Aluno: ");
                int idade = int.Parse(Console.ReadLine());
                
                
                Console.Write("Qual a nota do Aluno: ");
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                listaAlunos.Add(new Aluno(nome , idade, nota));

                a.SomaNotas(nota);


            }


            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine();
                Console.WriteLine(aluno);
                Console.WriteLine();
                Console.WriteLine("Total das notas: " + a.TotalNotas);
            }










        }
    }
}
