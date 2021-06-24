using System;
using System.Collections.Generic;
using System.Linq;

namespace CorrecaoDaProvaLP
{
    class Program
    {
        public static void X(string _x)
        {
            Console.WriteLine(_x);
        }

        static void Main(string[] args)
        {
            /**
             * Primeira Questão
             */
            /*List<string> f = new List<string>();

            f.Add("Pera");
            f.Add("Maçã");
            f.Add("Banana");
                        
            Console.WriteLine(f[3]);*/

            /****************************************************************************
             * Segunda Questão
             */
            /*A a = new A();

            a.a = "a";

            Console.WriteLine(a.a);
            Console.WriteLine(A.aa("aa"));

            Console.ReadKey();*/

            /****************************************************************************
             * Terceira Questão
             */
            /*List<Pedagio> pedagios = new List<Pedagio>()
            {
                new Pedagio() { Valor = 6.50, Localizacao = "Casa Branca" },
                new Pedagio() { Valor = 6.80, Localizacao = "Aguaí" },
                new Pedagio() { Valor = 7.60, Localizacao = "Mogi Guaçu" },
                new Pedagio() { Valor = 12.70, Localizacao = "Campinas" },
                new Pedagio() { Valor = 9.70, Localizacao = "Itupeva" },
                new Pedagio() { Valor = 9.80, Localizacao = "Caieras" }
            };

            // Quantidade de pedágios.
            Console.WriteLine("A quantidade de pedágios é {0} ", pedagios.Count);

            // Somatório dos pedágios.
            double total = pedagios.Sum(i => i.Valor);
            Console.WriteLine("Soma dos pedágios é {0} ", total);

            // Pedágio mais barato
            Pedagio barato = pedagios.OrderBy(i => i.Valor).First();
            Console.WriteLine("O pedágio mais barato é em {0} e custa {1}", barato.Localizacao, barato.Valor);

            // Pedágio mais caro
            Pedagio caro = pedagios.OrderByDescending(i => i.Valor).First();
            Console.WriteLine("O pedágio mais barato é em {0} e custa {1}", caro.Localizacao, caro.Valor);*/

            /****************************************************************************
             * Quarta Questão
             */
            List<int> id = new List<int> { 20, 31, 24, 18 };

            int reps = 0;

            for (int i = 0; i < id.Count; i++)
            {
                reps++;
                Console.WriteLine("Repetição {0} ", reps);
                id.Add(i);
                Console.WriteLine(" Posição: {0}, Item: {1}", i, id[i]);

                if (i == 100) break;
            }

            /****************************************************************************
             * Quinta Questão
             */
            //                                      0          1        2        3         4          5          6        7        8 ??
            /*List<string> x = new List<string> { "Mercurio", "Venus", "Terra", "Marte", "Jupiter", "Saturno", "Urano", "Netuno" };

            X(x[2]);           // Terra
            X(x[x.Count - 1]); // 8 - 1 = 7 = Netuno
            X(x[x.Count]);     // 8 => out of range.*/



            Console.ReadKey();


        }
    }
}
