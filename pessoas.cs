namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}

        public int Idade { get; set; }
         public string  Documento { get; set; }
        public virtual void Apresentar() 
        {
            console.writeLine($"Ola, meu nome eh {Nome} e tenho {IDade} anos");
        }
    }
}