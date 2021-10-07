using System;
using System.Collections.Generic;
using System.Globalization;


namespace Desafio_04
{
    class Aluno
    {
        public string Nome { get; set; } 
        public int Idade { get; set; }
        public double Nota { get; set; }

        public double TotalNotas { get; set; }


        //Construtor
        public Aluno (string nome, int idade, double nota)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Nota = nota;

        }

        // Função 
        public void SomaNotas(double nota)
        {
            TotalNotas += nota;
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", "
                + "Idade: "
                + Idade
                + ", "
                + "Nota: "
                + Nota.ToString("F2", CultureInfo.InvariantCulture);
        }


    }

    
}
