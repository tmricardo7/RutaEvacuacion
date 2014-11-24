using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Ruta_de_evacuación_más_cercana
{
    class Individuo
    {
        List<int> vector = new List<int>();
        
        
        int[,] matrizGuia = new int[20,20];
        int columna = 0;
        int fila = 0;
        int[] columnaPuerta;
        int[] filaPuerta;
        int movimiento = 0;
        int movAnterior = -1;
        int valorAnterior = 0;
        double calidad;

        //Constructor
        public Individuo()
        {
            calidad = 0;
        }
        
        //Constructor
        public Individuo(int[,] matrizOriginal, Random r, int numSalidas)
        {
            calidad = 20000;
            columnaPuerta = new int[numSalidas];
            filaPuerta = new int[numSalidas];
            setMatrizGuia(matrizOriginal);
            int f = fila;
            int c = columna;
            do
            {
                fila = f;
                columna = c;
                vector = new List<int>(); 
                int i = 0;
                vector.Add(new int());
                vector[i] = ((fila * 20) + columna);
                matrizGuia[fila, columna] = 0;
                i++;
                do
                {
                    movimiento = r.Next(0, 8); //Tira un número aleatorio de 0 a 7
                    while (!esPosibleMover(movimiento))
                    {
                        movimiento = r.Next(0, 8);
                    }
                    mover(movimiento);
                    vector.Add(new int());
                    vector[i] = ((fila * 20) + columna);
                   // Debug.WriteLine(matrizGuia[fila, columna]);
                    calidad += Controlador.getValores(matrizGuia[fila, columna]);
                    i++;
                    movAnterior = movimiento;
                    valorAnterior = matrizGuia[fila, columna];

                } while (!esPuerta(movimiento, numSalidas));
            } while (vector.Count > 400);
             
        }

        //Verifica si es salida
        private bool esPuerta(int mov, int nSalidas)
        {
            bool esPosible = false;
            for (int i = 0; i < nSalidas; i++)
            {
                if (columna == columnaPuerta[i] && fila == filaPuerta[i])
                {
                    esPosible = true;
                }
            }
            return esPosible;
        }

        //Imprime la ruta
        public void imprimir()
        {
            string s = "";
            for (int k = 0; k < vector.Count; k++)
            {
                s += vector[k].ToString() + " ";

            }
            MessageBox.Show(s);
        }

        //Verifica si es posible mover en cierta dirección
        private bool esPosibleMover(int mov)
        {
            bool esPosible = true;

            switch (mov)
            {
                case 0://izquierda
                    if (columna == 0 || (matrizGuia[fila, columna - 1] == 3) || movAnterior == 1)
                    {
                        esPosible = false;
                    }
                    break;
                case 1://derecha
                    if (columna == 19 || (matrizGuia[fila, columna + 1] == 3) || movAnterior == 0)                    
                    {
                        esPosible = false;
                    }
                    break;
                case 2://arriba
                    if (fila == 0 || (matrizGuia[fila - 1, columna] == 3) || movAnterior == 3)
                    {
                        esPosible = false;
                    }
                    break;
                case 3://abajo
                    if (fila == 19 || (matrizGuia[fila + 1, columna] == 3) || movAnterior == 2)
                    {
                        esPosible = false;
                    }
                    break;
                case 4://arriba-izq
                    if (fila == 0 || columna == 0 || (matrizGuia[fila - 1, columna - 1] == 3) || movAnterior == 7)
                    {
                        esPosible = false;
                    }
                    break;
                case 5://abajo-izq
                    if (fila == 19 || columna == 0 || (matrizGuia[fila + 1, columna - 1] == 3) || movAnterior == 6)
                    {
                        esPosible = false;
                    }
                    break;
                case 6://arriba-der
                    if (fila == 0 || columna == 19 || (matrizGuia[fila - 1, columna + 1] == 3) || movAnterior == 5)
                    {
                        esPosible = false;
                    }
                    break;
                case 7://abajo-der
                    if (fila == 19 || columna == 19 || (matrizGuia[fila + 1, columna + 1] == 3) || movAnterior == 4)
                    {
                        esPosible = false;
                    }
                    break;
                case 8://no se mueve
                    break;
            }

            return esPosible;
        }


        //Mueve en cierta dirección
        private void mover(int mov)
        {
            switch (mov)
            {
                case 0://izquierda
                    //matrizGuia[fila, columna - 1] = 6;
                    columna--;
                    break;
                case 1://derecha
                 //   matrizGuia[fila, columna + 1] = 6;
                    columna++;
                    break;
                case 2://arriba
               //     matrizGuia[fila - 1, columna] = 6;
                    fila--;
                    break;
                case 3://abajo
                //    matrizGuia[fila + 1, columna] = 6;
                    fila++;
                    break;
                case 4://arriba-izq
                 //   matrizGuia[fila - 1, columna - 1] = 6;
                    fila--;
                    columna--;
                    break;
                case 5://abajo-izq
               //     matrizGuia[fila + 1, columna - 1] = 6;
                    fila++;
                    columna--;
                    break;
                case 6://arriba-der
              //      matrizGuia[fila - 1, columna + 1] = 6;
                    fila--;
                    columna++;
                    break;
                case 7://abajo-der
                 //   matrizGuia[fila + 1, columna + 1] = 6;
                    fila++;
                    columna++;
                    break;

            }            
        }

        public double getCalidad()
        {
            /*
            double suma = 0.0;
            for (int i = 0; i < vector.Count; i++ )
            {
                int filav = (vector[i] / 20);
                int columv = (vector[i] - (20 * filav));
                suma += matrizGuia[filav, columv] + 1;*/
                //int rangoActual = matrizGuia[filav,columv];
                //Debug.WriteLine(rangoActual);
                //suma += Controlador.getValores(rangoActual);

            
           // Debug.WriteLine(suma);
            
            return calidad;
        }

        //Obtiene el vector
        public List<int> getVector()
        {
            return vector;
        }

        //Establece el vector
        public void setVector(List<int> v)
        {
            vector = v.ConvertAll(x => x);
        }

        public void setCalidad(double n) {
            calidad = n;
        
        }

        //Obtiene la casilla que hay en una posición
        public int getCasilla(int posicion)
        {
            return vector[posicion];
        }

        //Establece la matriz guía
        private void setMatrizGuia(int[,] matriz)
        {
            int l = 0;
            for(int i = 0; i<20; i++)
            {
                for(int j = 0; j<20; j++)
                {
                    matrizGuia[i,j] = matriz[i,j];
                    if (matrizGuia[i, j] == 4)
                    {
                        fila = i;
                        columna = j;
                    }
                    else
                    {
                        if (matrizGuia[i, j] == 5)
                        {
                            filaPuerta[l] = i;
                            columnaPuerta[l] = j;
                            l++;
                        }
                    }
                }
            }
        }

        //Obtiene la longitud de la ruta
        public int obtenerLongitud()
        {
            return vector.Count;
        }
    }
}
