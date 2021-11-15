﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Condição Simples
            //int valor = 10;

            //if (valor ==5)
            //{
            //    Console.WriteLine("Condiçã Verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condiçã Falso");
            //}

            //Console.ReadKey();
            #endregion

            #region Condição Composta ou Encadeada

            int valor = 21;

            if (valor < 5)
            {
                Console.WriteLine("Condiçã Verdadeira 1");
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição verdadeira 2");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição verdadeira 3");
            }
            else
            {
                Console.WriteLine("Condição final");
            }

            Console.ReadKey();

            #endregion

            #region Operador Ternário

            //int numero = 10;
            //string mensagem = "";
            // variavel = condição ? true : false;
            //mensagem = numero > 5 ? "Maior que 5" : "MENOR QUE 5";


            // pode ser feito dessa forma tambem, sem fazer declaração da variavel msg
            //string mensagem = ""; - não precisa
            //string mensagem = numero > 5 ? "Maior que 5" : "MENOR QUE 5";


            //pode ser feito dessa forma tambem:
            //int numero = 10;
            //Console.WriteLine(numero > 5 ? "Maior que 5" : "MENOR QUE 5");
            //Console.ReadKey();

            #endregion


        }
    }
}
