using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeNumerosAleatorios
{
    class ChiCuadrado
    {
        public ChiCuadrado()
        {
        }

        public Intervalo[] getFrequencies(List<decimal> serie, int k)
        {
            if ((serie.Count / k) < 5) k /= 2; //Para distribución uniforme

            Intervalo[] intervalos = new Intervalo[k];
            double acum = 0;
            for (int j = 0; j < k; j++)
            {
                intervalos[j] = new Intervalo(0, 0);
                intervalos[j].LimInf = (decimal) acum;
                acum += (double) 1/k;
                intervalos[j].LimSup = (decimal) acum;                
            }

            int n = serie.Count;

            for (int i = 0; i < n; i++)
            {
                foreach (Intervalo interv in intervalos)
                {
                    if (interv.belongsToMe(serie[i]))
                    {
                        interv.contador += 1;
                        break;
                    }
                }
            }
            
            return intervalos;
        }

        public double calcEstadistico(Intervalo[] intervalos, int n)
        {
            double c = 0;
            double fe = (n / intervalos.Length); //Revisar si la frecuencia esperada debe ser un int o un double

            foreach (Intervalo interv in intervalos)
            {
                c += Math.Pow((fe - interv.contador), 2) / fe;
            }

            return c;
        }
    }

    
}
