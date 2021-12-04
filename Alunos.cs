using System;

namespace ExemploPoo.Models
{
    public class Aluno : pessoas
    {
        public int Nota { get; set; }

         public override void Apresentar() 
        {
            console.writeLine($"Ola, meu nome eh {Nome} e sou aluno nota {nota}");
        }
    }
}