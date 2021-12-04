using System;

namespace ExemploPoo.Models
{
    public class Professor : pessoas
    {
        public double Salario { get; set; }

         public override void Apresentar() 
        {
            console.writeLine($"Ola, meu nome eh {Nome} e sou um professor, e ganho {Salario}");
        }
    }
}