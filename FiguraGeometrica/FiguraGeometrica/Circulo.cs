using System;
using System.Collections.Generic;
using System.Text;

namespace FiguraGeometrica
{
    class Circulo : IAreaCalculavel
    {
        //Propriedades
        public double Raio { get; set; }
        //Construtor
        public Circulo()
        {
            Raio = 0;
        }

        public void LerDados()
        {
            try
            {
                Console.Write("\n Raio do Circulo: ");
                Raio = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("\n Erro de Leitura: " + ex);
            }
        }

        public override string ToString()
        {
            return "\n ----- Circulo ------ \n Raio: " + Raio +
                "\n Área do circulo : " + CalcularArea();
        }

        public double CalcularArea()
        {
            return Math.PI* (Raio*Raio);
        }
    }
}
