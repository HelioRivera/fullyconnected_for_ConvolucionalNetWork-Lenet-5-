using fullyconnected_for_ConvolucionalNetWork_Lenet_5_.FullyConected;
using System;
using System.Collections.Generic;

namespace fullyconnected_for_ConvolucionalNetWork_Lenet_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random(0);
            List<double> input = new List<double>();

            input.Add(azar.NextDouble());

            input.Add(azar.NextDouble());

            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());
            Mlp red = new Mlp(input);
            red.feedForward();
            /*Random azar = new Random(0);

            List<double> input = new List<double>();

            input.Add(azar.NextDouble());

            input.Add(azar.NextDouble());

            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());
            input.Add(azar.NextDouble());


            FullyConectedLayer capa1 = new FullyConectedLayer(azar,120,input.Count,"tanh");
            
            capa1.CalculaSalidaDeCapa(input);

            //Program.ShowCapa(capa1);

            FullyConectedLayer capa2 = new FullyConectedLayer(azar, 84, capa1.GetNeuronas().Count,"tanh");

            capa2.CalculaSalidaDeCapa(capa1.GetSalida());

            FullyConectedLayer capa3 = new FullyConectedLayer(azar, 28, capa2.GetNeuronas().Count, "softmax");

            capa3.CalculaSalidaDeCapa(capa2.GetSalida());

            Program.ShowCapa(capa3);*/

        }

        /*public static void ShowCapa(FullyConectedLayer capa)
        {
            List<double> list = capa.GetSalida();

            foreach (double valor in list)
            {
                Console.WriteLine(valor);
            }

        }*/
    }
}
