using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void visualTopoCalculadora()
        {
            Console.Write("\n ##########################\n #   CALCULADORA DE IMC   # \n ##########################");
        }

        static void resultadoImc(string classificacaoImc)
        {
            Console.Write(" --------------------------\n |" + classificacaoImc + "| \n --------------------------\n");
        }

        static void Main(string[] args)
        {
            string dadoDigitado;
            double peso, altura, imcFinal;

            // peso:
            Console.Clear();
            visualTopoCalculadora();
            while (true) 
            {
                try
                {
                    Console.Write("\n\n Digite o seu PESO\n (medida em QUILO, kg)");
                    Console.Write("\n\n --> ");
                    dadoDigitado = Console.ReadLine();
                    dadoDigitado = dadoDigitado.Replace(".", ",");
                    peso = double.Parse(dadoDigitado);
                    if (peso < 1000 && peso > 0) break;
                    Console.Clear();
                    visualTopoCalculadora();
                    Console.WriteLine("\n\n\n ERRO 11 - Entrada Inválida, Digite um Número VÁLIDO \n (Maior que 0 e Menor que 1000)");
                }
                catch
                {
                    Console.Clear();
                    visualTopoCalculadora();
                    Console.WriteLine("\n\n\n ERRO 12 - Entrada Inválida, Digite um NÚMERO Válido \n (Maior que 0 e Menor que 1000)");
                }
            }

            // altura:
            Console.Clear();
            visualTopoCalculadora();
            while (true)
            {
                try
                {
                    Console.Write("\n\n Digite a sua ALTURA\n (medida em METROS, m)");
                    Console.Write("\n\n --> ");
                    dadoDigitado = Console.ReadLine();
                    dadoDigitado = dadoDigitado.Replace(".", ",");
                    altura = double.Parse(dadoDigitado);
                    if (altura < 3 && altura > 0) break;
                    Console.Clear();
                    visualTopoCalculadora();
                    Console.WriteLine("\n\n\n ERRO 21 - Entrada Inválida, Digite um Número VÁLIDO \n (Maior que 0 e Menor que 3)");
                }
                catch
                {
                    Console.Clear();
                    visualTopoCalculadora();
                    Console.WriteLine("\n\n\n ERRO 22 - Entrada Inválida, Digite um NÚMERO Válido \n (Maior que 0 e Menor que 3)");
                }
            }

            //resultado imc
            altura *= altura;
            imcFinal = Math.Round(peso / altura, 2);                
            Console.Clear();
            visualTopoCalculadora();
            Console.Write("\n\n Seu IMC é de "+imcFinal+"\n\n Você está na Classificação \n\n");
            if (imcFinal < 16) resultadoImc("    MAGREZA GRAU III    ");
                else if (imcFinal < 17) resultadoImc("    MAGREZA GRAU II     ");
                    else if(imcFinal < 18.5) resultadoImc("     MAGREZA GRAU I     ");
                        else if (imcFinal < 25) resultadoImc("        ADEQUADO        ");
                            else if(imcFinal < 30) resultadoImc("       PRÉ OBESO        ");
                                else if(imcFinal < 35) resultadoImc("    OBESIDADE GRAU I    ");
                                    else if(imcFinal < 40) resultadoImc("    OBESIDADE GRAU II   ");
                                        else resultadoImc("   OBESIDADE GRAU III   ");
            Console.Write("\n\n\n (Pressione qualquer tecla para SAIR)");
            peso = 0;
            altura = 0;
            Console.ReadKey();
        }
    }
}
