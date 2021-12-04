using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interface; 
using ExemploPOO.Models;

namespace ExemploPoo
{
    class Program
    {
       
       static void Main(string[] args)
       {

           //Listar ARquivos, Criar, Apagar
           var caminho = "C:\\TrabalhandoComArquivos";
           var camninhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
           var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
           var novocaminhoArquivo = Path.Combine(caminho,"Pasta teste2", "arquivo-teste-stream.txt");
           var caminhoArquivoTeste = Path.Combine(caminho,"Pasta teste2", "arquivo-teste.txt");
           var caminhoArquivoTesteCopia = Path.Combine(caminho,"Pasta teste2", "arquivo-teste-bkp.txt");
           
           var listaString = new List<string> {"Linha 1","Linha 2", "Linha 3" };
           var listaStringContinuacao = new List<string> { "Linha 4 ", "Linha 5 ", "Linha 6"};

           FileHelper helper = new FileHelper();
           //helper.ListarArquivosDiretorios(caminho);
           //System.Console.WriteLine("Criando diretorio:"+ camninhoPathCombine);
           //helper.CriarDiretorio(Path.Combine(caminho, "Pasta teste 3" , "SubPastaTeste3"));
           // helper.ApagarDiretorio(camninhoPathCombine, true);
           //helper.CriarArquivosTexto(caminhoArquivo, "Ola teste de escrita de arquivo");
           //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
           //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
           //helper.LerArquivoStream(caminhoArquivo);
           // helper.MoverArquivo(caminhoArquivo , novocaminhoArquivo, false);
           //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

          //Listar Diretorios
          //var caminho = "C:\\TrabalhandoComArquivos";
          //FileHelper helper = new FileHelper();
          //helper.ListarDiretorios(); 
                     
           //ICalculadora calc = new calculadora();
           //System.Console.WriteLine(calc.Somar(10,20));
      
            //Conta Corrente
            //Corrente c = new Corrente();
            //c.Creditar(100);
            //c.ExibirSaldo();

            //calculadora calc = new calculadora();
            //System.Console.WriteLine("Resultado da primeira soma:" + calc.Somar(10,10));
            //System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(10,10,10));

            //Alunos
            //Aluno p1 =  new Aluno();
            //p1.Nome = "Bob";
            //p1.Idade = 20;
            //p1.Documento = 123456;
            //p1.Nota = 10;
            //p1.Apresentar();

            //Professores
            // Professor p2 =  new Professor();
            //p2.Salario = 1000;
            //p2.Nome = "Bob";
            //p2.Idade = 20;
            //p2.Documento = 123456;
            //p2.Apresentar();

            //valores validos
            //Retangulo r = new Retangulo();
            //r.DefinirMedidas(30, 30);
            //System.Console.WriteLine("Area: {r.ObterArea()}");

            //valores invalidos
            //Retangulo r2 = new Retangulo();
            //r2.DefinirMedidas(0, 0);
            //System.Console.WriteLine("Area: {r2.ObterArea()}");

            //Pessoa
            //Pessoa p1 =  new Pessoa();
            //p1.Nome = "Bob";
            //p1.Idade = 20;
            //p1.Apresentar();
       } 

        

            
        }
    }
}
