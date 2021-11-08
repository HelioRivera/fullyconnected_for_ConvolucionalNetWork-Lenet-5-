using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullyconnected_for_ConvolucionalNetWork_Lenet_5_.FullyConected
{
    class FullyConectedLayer
    {
        List<Neurona> neuronas; //Las neuronas que tendrá la capa
        List<double> salidas; //Almacena las salidas de cada neurona
        String id;

        /*totalNeuronas : corresponde a la cantidad de neuronas en la capa actual.
         totalEntradas : corresponde a la cantidad de entradas en la capa actual*/
        public FullyConectedLayer(Random azar, int totalNeuronas, int totalEntradas, String tipoCapa)
        {
            neuronas = new List<Neurona>();
            salidas = new List<double>();
            id = tipoCapa;            
            
            //Genera las neuronas e inicializa sus salidas
            for (int cont = 0; cont < totalNeuronas; cont++)
            {
                neuronas.Add(new Neurona(azar, totalEntradas));
                salidas.Add(0);
            }

            Console.WriteLine("totalNeuronas: " + totalNeuronas);
            Console.WriteLine("totalEntradas: " + totalEntradas);
            Console.WriteLine("tipoCapa: " + tipoCapa);

        }

        public void CalculaSalidaDeCapa(List<double> entradas)
        {
            if (id == "softmax")
            {
                Console.WriteLine("aplicando funcion de activacion " + id);

                SoftMax();
            }
            if(id == "tanh")
            {
                Console.WriteLine("aplicando funcion de activacion " + id);

                for (int cont = 0; cont < neuronas.Count; cont++)
                {
                    salidas[cont] = ActivacionTanh(neuronas[cont].CalculaPreActivacion(entradas));

                    Console.WriteLine(salidas[cont]);
                }

            }
        }

        //softmax con un detalle minimo no revisado aun a fecha 8/11/2021
        private void SoftMax()
        {
            double suma = 0;
            for (int j = 0; j < salidas.Count; j++)
            {
                suma += Math.Exp(salidas[j]);
            }

            List<double> salidasAux = salidas;

            for (int i = 0; i < salidasAux.Count; i++)
            {
                salidas[i] = Math.Exp(salidasAux[i]) / suma;
            }

        }

        private double ActivacionTanh(double valor)
        {
            return Math.Tanh(valor);
        }

        public List<double> GetSalida()
        {
            return salidas;
        }

        public List<Neurona> GetNeuronas()
        {
            return neuronas;
        }
    }
}
