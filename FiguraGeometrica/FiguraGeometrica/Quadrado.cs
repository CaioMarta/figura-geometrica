using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    class Quadrado : IAreaCalculavel
    {
        //propriedade
        public double Lado { get; set; }

        //Construtor
        public Quadrado()
        {
            Lado = 0;
        }

        //Metodos de Classe
        public void LerDados()
        {
            try
            {
                Console.Write("\n Lado do Quadrado: ");
                Lado = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.Write("\n Erro de Leitura: " + ex);
            }
        }

        public override string ToString()
        {
            return "\n ----- Quadrado ------ \n Lado: " + Lado +
                "\n Área do quadrado: " + CalcularArea();
        }
        public double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
