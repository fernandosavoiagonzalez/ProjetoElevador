using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            int andarAtual = 0;
            int andarAlvo = 1;
            int numPessoasAtual = 0;
            

            Console.WriteLine("Escreva o número total de andares do prédio:");
            int totalAndares = int.Parse((Console.ReadLine()));

            Console.WriteLine("Escreva a capacidade máxima do elevador:");
            int capacidade = int.Parse((Console.ReadLine()));

            Elevador elevador = new Elevador();

            while (andarAlvo != 0)
            {
                Console.WriteLine("Digite o andar que voce quer ir:");
                andarAlvo = int.Parse(Console.ReadLine());


                if (andarAlvo > andarAtual)
                {
                    numPessoasAtual = elevador.Entrar(capacidade, numPessoasAtual);
                    andarAtual = elevador.Subir(andarAlvo, totalAndares, andarAtual);
                    
                }

                if (andarAlvo < andarAtual)
                {
                    numPessoasAtual = elevador.Entrar (capacidade, numPessoasAtual);
                    andarAtual = elevador.Descer(andarAtual, andarAlvo);
                }

                if (andarAlvo == andarAtual)
                {
                    numPessoasAtual = elevador.Sair (numPessoasAtual);
                }


            }
        }
    }
}

