using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullyconnected_for_ConvolucionalNetWork_Lenet_5_.FullyConected
{
    class Mlp
    {
        private Random azar;
        private FullyConectedLayer capa1;
        private FullyConectedLayer capa2;
        private FullyConectedLayer capa3;
        private List<double> input;

        public Mlp(List<double> input)
        {
            this.input = input;
            azar = new Random(0);
            capa1 = new FullyConectedLayer(azar, 120, input.Count, "tanh");
            capa2 = new FullyConectedLayer(azar, 84, capa1.GetNeuronas().Count, "tanh");
            capa3 = new FullyConectedLayer(azar, 28, capa2.GetNeuronas().Count, "softmax");
        }
        
        public void feedForward()
        {
            capa1.CalculaSalidaDeCapa(input);
            capa2.CalculaSalidaDeCapa(capa1.GetSalida());
            capa3.CalculaSalidaDeCapa(capa2.GetSalida());
            ShowCapa(capa3);
        }

        private  void ShowCapa(FullyConectedLayer capa)
        {
            List<double> list = capa.GetSalida();

            foreach (double valor in list)
            {
                Console.WriteLine(valor);
            }

        }
    }
}
