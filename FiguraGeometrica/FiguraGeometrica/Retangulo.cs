using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    class Retangulo : IAreaCalculavel
    {
        //propriedades
        public double Altura { get; set; }
        public double Largura { get; set; }

        //Construtor 
        public Retangulo()
        {
            Altura = 0;
            Largura = 0;
        }

        //Métodos da Classe
        public void LerDados()
        {
            try
            {
                Console.Write("\n Altura do Retângulo: ");
                Altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n Largura do Retângulo: ");
                Largura = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.Write("\n Erro de Leitura ");
            }
        }

        public override string ToString()
        {
            return "\n ***** Retângulo ****** \n Altura:" + Altura +
                "\n Área do Retângulo: " + CalcularArea();
        }
        public double CalcularArea()
        {
            return Altura * Altura;
        }
    }
}
