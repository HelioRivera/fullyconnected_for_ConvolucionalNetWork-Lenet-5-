using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullyconnected_for_ConvolucionalNetWork_Lenet_5_.FullyConected
{
    class Neurona
    {
        private List<double> pesos; //Los pesos para cada entrada
        double umbral; //El peso del umbral

        public Neurona(Random azar, int totalEntradas)
        {
            pesos = new List<double>();
            for (int cont = 0; cont < totalEntradas; cont++)
            {
                pesos.Add(azar.NextDouble());
                //Console.WriteLine(pesos[cont]);

            }
            umbral = azar.NextDouble();
        }


        public double CalculaPreActivacion(List<double> entradas)
        {
            double valor = 0;
            for (int cont = 0; cont < pesos.Count; cont++)
            {
                valor += entradas[cont] * pesos[cont];
            }
            valor += umbral;

            //Console.WriteLine(valor);

            return valor;

        }

        public List<double> GetPesos()
        {
            return pesos;
        }

        public double GetUmbral()
        {
            return umbral;
        }

        /*private double Tanh(double valor)
         {
             return Math.Tanh(valor);
         }

         private double Sigmoide(double valor)
         {
             return 1 / (1 + Math.Exp(-valor));
         }*/
    }
}
