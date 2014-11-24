using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Ruta_de_evacuación_más_cercana
{
    class Controlador
    {
        const int indPorGen = 100;
        const int numHijos = 80;
        int[,] matrizOriginal = new int[20,20];
        Individuo[] poblacion = new Individuo[indPorGen];
        double[] evaluaciones = new double[indPorGen];
        double[] probDeCruzar = new double[indPorGen];
        Random r = new Random(DateTime.Now.Millisecond);

        private static double[] valores = new double[6]; 


        public void setValores(int n, double v) {
            valores[n] = v;
        }

        public static double getValores(int n) {
            return valores[n];
        }

        //Ordena 2 vectores utilizando con respecto a solo los valores de uno de ellos
        private void bubblesortSimultaneo()
        {
            int len = indPorGen;
            for (int i = 1; i < len; ++i)
            {
                for (int j = 0; j < len - 1; ++j)
                {
                    if (evaluaciones[j] < evaluaciones[j + 1])
                    {
                        double temp = evaluaciones[j];
                        evaluaciones[j] = evaluaciones[j + 1];
                        evaluaciones[j + 1] = temp;
                        Individuo posicionTemp = poblacion[j];
                        poblacion[j] = poblacion[j + 1];
                        poblacion[j + 1] = posicionTemp;
                        //se ordenan los 2 arreglos de mayor a menor según los evaluaciones, de manera que exista un paralelismo y así poder determinar la posición en la cual se encuentra la palabra que tenga cierto porcentaje
                    }
                }
            }
        }

        //Inicia el algoritmo genético
        public List<int> iniciar(int[,] laMatriz, int numSalidas)
        {
            valores[3] = 0;
            valores[4] = 0;
            valores[5] = 0;


            setMatrizOriginal(laMatriz); //quitar
            inicializarPoblacion(numSalidas);
            int y = 0;
            while (y<10000)
            {
                Debug.WriteLine(y + "<>" + poblacion[0].getCalidad() + "::" + poblacion[29].getVector().Count);
                ordenarPoblacion();
                
                cruzar();
                
                //if(y == 0 || y == 9999)
                    //poblacion[0].imprimir();
                y++;
            }
            return poblacion[0].getVector();
        }

        //Muta un individuo
        private void mutar(int g)
        {
            Random r2 = new Random(DateTime.Now.Millisecond);
            int punto1 = r2.Next(0, poblacion[g].obtenerLongitud());
            double casillaUnion = poblacion[g].getCasilla(punto1);
            int punto2 = -1;

            for (int k = (poblacion[g].obtenerLongitud() - 1); k >= 0; k--)
            {
                if (poblacion[g].getCasilla(k) == casillaUnion)
                {
                    punto2 = k;
                    break;
                }
            }

            if (punto2 != punto1)
            {
                List<int> v = new List<int>();

                int contadorPos = 0;
                double calidad = 0;
                for (int h = 0; h < punto1; h++)
                {
                    v.Add(new int());
                    v[contadorPos] = poblacion[g].getCasilla(h);
                    calidad += getValores(getValorCasilla(v[contadorPos]));

                    contadorPos++;
                }
                for (int p = punto2; p < poblacion[g].obtenerLongitud(); p++)
                {
                    v.Add(new int());
                    v[contadorPos] = poblacion[g].getCasilla(p);
                    calidad += getValores(getValorCasilla(v[contadorPos]));

                    contadorPos++;
                }
                poblacion[g].setVector(v);
                poblacion[g].setCalidad(calidad);
            }

        }

        private int getValorCasilla(int v) {
            int filav = ( v / 20);
            int columv = (v - (20 * filav));
            return matrizOriginal[filav, columv];
        }

        //Calcula los porcentajes de cruce
        private void calcularPorcentajeDeCruce()
        {
            double total = 0;

            for (int i = 0; i < indPorGen; i++)
            {
                total += evaluaciones[i];
            }
            double temporal = 0;
            for (int j = 0; j < indPorGen; j++)
            {
                
                temporal += (evaluaciones[j] / total);
                probDeCruzar[j] = temporal;
            }
        }

        //Cruza los individuos
        private void cruzar()
        {
            
            calcularPorcentajeDeCruce();
            Individuo[] hijo = new Individuo[numHijos];
            Individuo padre = new Individuo();
            Individuo madre = new Individuo();
            Random r = new Random(DateTime.Now.Millisecond);

            for (int u = 0; u < numHijos; u++)
            {
                    double probCruce1 = r.NextDouble();
                    double calidad = 0;
                    int i = 0;
                    int j = 0;
                    for (i = 0; i < indPorGen; i++)
                    {
                        if (probDeCruzar[i] > probCruce1)
                        {
                            padre = poblacion[i];
                            break;
                        }                
                    }

                    do
                    {
                        double probCruce2 = r.NextDouble();
                        for (j = 0; j < indPorGen; j++)
                        {
                            if (probDeCruzar[j] > probCruce2)
                            {
                                madre = poblacion[j];
                                break;
                            }
                        }
                    } while (i == j);//VERIFICA QUE PADRE NO ES IGUAL A MADRE

            
                hijo[u] = new Individuo();
                int puntoCrucePadre = r.Next(0, padre.obtenerLongitud());//calcula punto de cruce (casilla aleatoria)
                double casillaUnion = padre.getCasilla(puntoCrucePadre);
                int puntoCruceMadre = -1;
                int longitudMadre = madre.obtenerLongitud();
                List<int> v = new List<int>();
                //busca esa casilla en el otro individuo (ultima ocurrencia)

                for (int k = (longitudMadre - 1); k >= 0; k--)
                {
                    if (madre.getCasilla(k) == casillaUnion)
                    {
                        puntoCruceMadre = k;
                    }
                }

                if (puntoCruceMadre != -1)
                {
                    //copia en el nuevo individuo las 2 partes que se tomaron

                    int contadorPos = 0;
                    for (int h = 0; h < puntoCrucePadre; h++)
                    {
                        v.Add(new int());
                        v[contadorPos] = padre.getCasilla(h);
                        calidad += getValores(getValorCasilla(v[contadorPos]));


                        contadorPos++;
                    }
                    for (int p = puntoCruceMadre; p < longitudMadre; p++)
                    {
                        v.Add(new int());
                        v[contadorPos] = madre.getCasilla(p);
                        calidad += getValores(getValorCasilla(v[contadorPos]));

                        contadorPos++;
                    }
                    hijo[u].setVector(v);
                    hijo[u].setCalidad(calidad);

                }
                else
                {
                    hijo[u].setVector(padre.getVector()); //No hay casillas en común
                    hijo[u].setCalidad(padre.getCalidad());

                }
            }
            int rrr = 1;
            Random r1 = new Random(DateTime.Now.Millisecond);
            for (int t = 0; t < numHijos; t++)
            {
                
                poblacion[indPorGen - rrr] = hijo[t];
                if (r1.NextDouble() < 0.5)
                {
                    mutar(indPorGen - rrr);
                }
                rrr++;
            }

        }
        /*
        //Ordena la población con respecto a sus evaluaciones
        private void ordenarPoblacion()
        {
            /*double tot = 0;
            for (int i = 0; i < indPorGen; i++)
            {
                evaluaciones[i] = poblacion[i].obtenerLongitud();
                tot += evaluaciones[i];
            }

            for (int j = 0; j < indPorGen; j++)
            {
                evaluaciones[j] = tot - evaluaciones[j];
            }

            bubblesortSimultaneo();

            poblacion = poblacion.OrderBy(x => x.getCalidad()).ToArray();
            for (int i = 0; i < indPorGen; i++)
            {
                evaluaciones[i] = poblacion[i].getCalidad();
            }

        }*/

        private void ordenarPoblacion()
        {
            double tot = 0;
            for (int i = 0; i < indPorGen; i++)
            {
                evaluaciones[i] = poblacion[i].getCalidad();
                tot += evaluaciones[i];
            }

            for (int j = 0; j < indPorGen; j++)
            {
                evaluaciones[j] = tot - evaluaciones[j];
            }

            bubblesortSimultaneo();
        }

        //Inicializa la población
        private void inicializarPoblacion(int numSalidas)
        {
            for (int i = 0; i < indPorGen; i++)
            {
                poblacion[i] = new Individuo(matrizOriginal,r,numSalidas);
            }
        }

        //Establece la matriz original
        private void setMatrizOriginal(int[,] matriz)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matrizOriginal[i, j] = matriz[i, j];
                }
            }
        }
    }
}
