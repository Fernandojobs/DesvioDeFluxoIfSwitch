using System;

namespace OperacoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario in-line (em linha)
            /*
                Comentario in-block (em bloco)
            */
            // declaração da variavel opreração. Ela será do tipo inteiro 
            int operacao;

            //declaração das variavel n1 e n2. Elas serão do tipo double
            double n1, n2;

            /*
            Para limpar a tela de comando a cada execusão, utilizaremos o comando Console.Clear ();
            Obs: Clear ->Limpar
            */
            Console.Clear();
            Console.WriteLine ("Ecolha um das operações abaixo:");
            /*
            Para exibição das opções de operações, vamos usar o comando Console.Writeline e, nele
            usaremos um comando de quebra de linha \n(contra-barra n(new line)). Assim, as opções 
            ficarão uma avaixo da outra
            */
            Console.WriteLine("1-Soma\n2-Subtrair\n3-Multiplicar\n4-Dividir");
            operacao = int.Parse (Console.ReadLine());
            Console.WriteLine ("Digite um numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número:");
            n2 = double.Parse(Console.ReadLine());

          if(operacao==1)
          {
            Console.WriteLine("O resultado da soma é:"+(n1+n2));
          }   
          else if (operacao==2)
          {
          Console.WriteLine("O resultado da subtração é:"+(n1-n2));
          }      
          else if (operacao==3)
          {
          Console.WriteLine("O resultado da multiplicação é:"+(n1*n2));
          } 
           else if (operacao==4)
           {  
          Console.WriteLine("O resultado da dividir é:"+(n1/n2));
          }

          else{
              Console.WriteLine("Operação invalida!");
          }
            


        }
    }
}
