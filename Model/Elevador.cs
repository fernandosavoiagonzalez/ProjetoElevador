using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        public int Inicializar (int capacidade, int totalAndares) 
        {
            return 0;
        } 
        
        public int Entrar (int capacidade, int numPessoasAtual)
        {
                if (numPessoasAtual < capacidade)
                {
                    numPessoasAtual = numPessoasAtual + 1;
                }
                else
                {
                    Console.WriteLine("Elevador lotado!");
                }
            return numPessoasAtual;
        }

        public int Sair (int numPessoasAtual)
        {
            if (numPessoasAtual != 0)
            {
                numPessoasAtual = numPessoasAtual - 1;
            }
            else
            {
                Console.WriteLine("Elevador vazio!");
            }
            return numPessoasAtual;

        }

        public int Subir (int andarAlvo, int totalAndares, int andarAtual)
        {
        if (andarAlvo > totalAndares)
                Console.WriteLine ("O edifício só tem " + totalAndares.ToString() + "andares." );

        else
            {

                while (andarAtual != andarAlvo)
                {
                andarAtual = andarAtual + 1;
                Console.WriteLine("Subindo... " + andarAtual.ToString());
                }

            Console.WriteLine("Você chegou no andar número " + andarAlvo.ToString());
            Console.WriteLine("Até logo!");
            }

            return andarAtual; 
        }

        public int Descer (int andarAtual, int andarAlvo)
        {

               while (andarAtual != andarAlvo)
                {
                andarAtual = andarAtual - 1;
                Console.WriteLine("Descendo... " + andarAtual.ToString());
                }
            Console.WriteLine("Você chegou no andar número " + andarAlvo.ToString());
            Console.WriteLine("Até logo!");
   

        return andarAtual;
        }


    }
}
