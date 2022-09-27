using System;

namespace FiguraGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar objetos
            Quadrado quadrado = new Quadrado();
            Retangulo retangulo = new Retangulo();
            Circulo circulo = new Circulo();

            ///executar os métodos
            quadrado.LerDados();
            retangulo.LerDados();
            circulo.LerDados();

            Console.WriteLine(quadrado.ToString());
            Console.WriteLine(retangulo.ToString());
            Console.WriteLine(circulo.ToString());
        }
    }
}
