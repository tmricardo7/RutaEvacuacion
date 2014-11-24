using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Ruta_de_evacuación_más_cercana
{
    public partial class frmPrincipal : Form
    {
        private bool hubo_click = false;
        int[,] tabla = new int[20,20];
        int celdasMarcadas = 0;
        List<int> vectorMovimientos;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.ocultarCampos();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.hubo_click = true;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (hubo_click)
            {
                if (rdbBajo.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 0);
                }
                else if (rdbMedio.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 1);
                }
                else if (rdbAlto.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 2);
                }
                else if (rdbObstaculos.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 3);
                }
                else if (rdbSalida.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 5);
                }
                else if (rdbPersona.Checked)
                {
                    llenarCuadrado(e.X, e.Y, 4);
                }
                
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.hubo_click = false;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbBajo.Checked)
            {
                llenarCuadrado(e.X, e.Y, 0);
            }
            else if (rdbMedio.Checked)
            {
                llenarCuadrado(e.X, e.Y, 1);
            }
            else if (rdbAlto.Checked)
            {
                llenarCuadrado(e.X, e.Y, 2);
            }
            else if (rdbObstaculos.Checked)
            {
                llenarCuadrado(e.X, e.Y, 3);
            }
            else if (rdbSalida.Checked)
            {
                llenarCuadrado(e.X, e.Y, 5);
            }
            else if (rdbPersona.Checked)
            {
                llenarCuadrado(e.X, e.Y, 4);
            }
        }

        private void habilitar(bool habilitado)
        {
            this.rdbObstaculos.Enabled = habilitado;
            this.rdbPersona.Enabled = habilitado;
            this.rdbSalida.Enabled = habilitado;
            this.btnLimpiarTodo.Enabled = habilitado;
            this.rdbAlto.Enabled = habilitado;
            this.rdbBajo.Enabled = habilitado;
            this.rdbMedio.Enabled = habilitado;
            this.tbxAlto.Enabled = habilitado;
            this.tbxMedio.Enabled = habilitado;
            this.tbxBajo.Enabled = habilitado;
            this.gbxRiesgos.Enabled = habilitado;

        }

        private void mostrar_Patron()
        {
            panelExt.Visible = true;
            panel.Visible = true;
            gbxDibujo.Visible = true;
        }

        private void ocultarCampos()
        {
            panelExt.Visible = false;
            panel.Visible = false;
            gbxDibujo.Visible = false;
            btnCalcular.Visible = false;
            btnSimulacion.Visible = false;
        }

        //inicializa la matriz que contiene los datos del croquis
        private void inicializar()
        {
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    tabla[fila, columna] = 0;
                }
            }
        }

        //“pinta” cierta celda del croquis con un color específico recibido por parámetro
        private void llenarMatriz(int y, int x, int color)
        {
            Debug.WriteLine(x);
            int x1 = (x * 19) + 1;
            int x2 = x1 + 16;
            int y1 = (y * 19) + 1;
            int y2 = y1 + 16;
            for (int i = 0; i < 8; i++)
            {
                cuadrado(x1, x2, y1, y2, color);
                x1++;
                x2--;
                y1++;
                y2--;
            }
            Point punto = new Point(x1, y1);
            Pen lapiz = new Pen(Color.Black);
            switch (color)
            {
                case 0:
                    lapiz = new Pen(Color.LimeGreen);
                    break;
                case 1:
                    lapiz = new Pen(Color.Yellow);
                    break;
                case 2:
                    lapiz = new Pen(Color.Red);
                    break;
                case 3:
                    lapiz = new Pen(Color.DimGray);
                    break;
                case 4:
                    lapiz = new Pen(Color.DodgerBlue);
                    break;
                case 5:
                    lapiz = new Pen(Color.Fuchsia);
                    break;
            }
            panel.CreateGraphics().DrawEllipse(lapiz, new Rectangle(punto, new Size(1, 1)));
        }

        private void matriz()
        {
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    cuadrado(19 * columna, 19 * (columna + 1) - 1, 19 * fila, 19 * (fila + 1) - 1, -1);
                }
            }
        }

        //se “pinta” un pequeño cuadrado del croquis con un color específico recibido por parámetro
        private void cuadrado(int x1, int x2, int y1, int y2, int color)
        {
            Pen lapiz = new Pen(Color.Black);
            switch (color)
            {
                case 0:
                    lapiz = new Pen(Color.LimeGreen);
                    break;
                case 1:
                    lapiz = new Pen(Color.Yellow);
                    break;
                case 2:
                    lapiz = new Pen(Color.Red);
                    break;
                case 3:
                    lapiz = new Pen(Color.DimGray);
                    break;
                case 4:
                    lapiz = new Pen(Color.DodgerBlue);
                    break;
                case 5:
                    lapiz = new Pen(Color.Fuchsia);
                    break;
            }
            Point p1;
            Point p2;
            p1 = new Point(x1, y1);
            p2 = new Point(x1, y2);
            panel.CreateGraphics().DrawLine(lapiz, p1, p2);
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y1);
            panel.CreateGraphics().DrawLine(lapiz, p1, p2);
            p1 = new Point(x1, y2);
            p2 = new Point(x2, y2);
            panel.CreateGraphics().DrawLine(lapiz, p1, p2);
            p1 = new Point(x2, y1);
            p2 = new Point(x2, y2);
            panel.CreateGraphics().DrawLine(lapiz, p1, p2);
        }

        /*
         * COLORES:
         * 0 - verde, riesgo Bajo
         * 1 - amarillo, riesgo Medio
         * 2 - rojo, riesgo Alto
         * 3 - gris oscuro, obstáculo
         * 4 - azul, persona
         * 5 - fuchsia, salida
         */
        private void llenarCuadrado(int x, int y, int color)
        {
            int x1 = ((x / 19) * 19) + 1;
            int x2 = x1 + 16;
            int y1 = ((y / 19) * 19) + 1;
            int y2 = y1 + 16;
            for (int contador = 0; contador < 8; contador++)
            {
                cuadrado(x1, x2, y1, y2, color);
                x1++;
                x2--;
                y1++;
                y2--;
            }
            Point punto = new Point(x1, y1);
            Pen lapiz = new Pen(Color.Black);
            int x_aux = x / 19;
            int y_aux = y / 19;
            switch (color) 
            { 
                case 0:
                    lapiz = new Pen(Color.LimeGreen);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 0;
                    }
                    break;
                case 1:
                    lapiz = new Pen(Color.Yellow);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 1;
                    }
                    break;
                case 2:
                    lapiz = new Pen(Color.Red);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 2;
                    }
                    break;
                case 3:
                    lapiz = new Pen(Color.DimGray);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 3;
                    }
                    break;
                case 4:
                    lapiz = new Pen(Color.DodgerBlue);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 4;
                    }
                    break;
                case 5:
                    lapiz = new Pen(Color.Fuchsia);
                    if ((x_aux < 20 && x_aux >= 0) && (y_aux < 20 && y_aux >= 0))
                    {
                        tabla[y_aux, x_aux] = 5;
                    }
                    break;
            }
            panel.CreateGraphics().DrawEllipse(lapiz, new Rectangle(punto, new Size(1, 1)));
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            actualizarMatriz();
        }

        private void actualizarMatriz()
        {
            matriz();
            int color;
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    color = tabla[fila, columna];
                    llenarMatriz(fila, columna, color);
                }
            }
        }

        //limpia toda el área de croquis
        private void borrarColores()
        {
            matriz();
            inicializar();
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    llenarMatriz(fila, columna, 0);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoCroquisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.inicializar();
            this.mostrar_Patron();
            this.actualizarMatriz();
            this.habilitar(true);
            this.gbxDibujo.Enabled = true;
            this.btnCalcular.Visible = true;
            this.btnCalcular.Enabled = true;
            this.btnSimulacion.Visible = true;
            this.btnSimulacion.Enabled = false;
            this.celdasMarcadas = 0;
            this.guardarPlanoToolStripMenuItem.Enabled = true;
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            borrarColores();
        }

        //se encarga de cargar un determinado archivo en el área de croquis.
        private void abrirCroquisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarCampos();
            char[] c = { ' ' };
            string linea = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Ruta de evacuación más cercana\Archivos de ejemplo\";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog.FileName;
                FileStream archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                StreamReader s = new StreamReader(archivo);
                string[] datos;
                int filas = 0;
                int columnas = 0;
                for (int i = 0; i < 20; i++)
                {
                    linea = s.ReadLine();
                    datos = linea.Split(c);
                    foreach (string cadena in datos)
                    {
                        if (cadena != "")
                        {
                            tabla[filas, columnas++] = int.Parse(cadena);
                        }
                    }
                    filas++;
                    columnas = 0;
                }
                s.Close();
                archivo.Close();
                mostrar_Patron();
                habilitar(true);
                btnCalcular.Visible = true;
                btnCalcular.Enabled = true;
                btnSimulacion.Visible = true;
                btnSimulacion.Enabled = false;
                gbxDibujo.Enabled = true;
                guardarPlanoToolStripMenuItem.Enabled = true;
            }
        }

        //guarda el croquis dibujado por el usuario en un archivo.
        private void guardarPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int persona = 0;
            int salida = 0;
            celdasMarcadas = 0;
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    if (tabla[fila, columna] == 1 || tabla[fila, columna] == 2 || tabla[fila, columna] == 3 || tabla[fila, columna] == 4 || tabla[fila, columna] == 5)
                    {
                        celdasMarcadas++;
                    }
                    if (tabla[fila, columna] == 4) 
                    {
                        persona++;
                    }
                    if (tabla[fila, columna] == 5)
                    {
                        salida++;
                    }
                }
            }            
            if (celdasMarcadas == 0)
            {
                MessageBox.Show("El patrón esta en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (persona == 1)
                {
                    if (salida > 0)
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.InitialDirectory = @"C:\Ruta de Evacuación más cercana\Archivos de ejemplo\";
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                        {
                            string nombreArchivo = saveFileDialog.FileName;
                            FileStream archivo = new FileStream(nombreArchivo, FileMode.Create);
                            StreamWriter s = new StreamWriter(archivo);
                            for (int fila = 0; fila < 20; fila++)
                            {
                                for (int columna = 0; columna < 20; columna++)
                                {
                                    s.Write(tabla[fila, columna].ToString() + " ");
                                }
                                s.WriteLine();
                            }
                            s.Close();
                            archivo.Close();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Dibuje al menos una salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Dibuje una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            btnSimulacion.Enabled = false;
            labelEstadoP.Text = "Estado: Simulando...";
            iniciarSimulacion(this.vectorMovimientos);
            labelEstadoP.Text = "";
        }

        private void iniciarSimulacion(List<int> movimientos) 
        {
            int[,] tablaOriginal = new int[20,20];
            int laFila;
            int laCol;
            int fila = -1;
            int columna = -1;
            bool encontrado = false;
            int[] posiciones = new int[2];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tablaOriginal[i, j] = tabla[i,j];
                }
            }

            
            for (int i = 0; i < 20 && !encontrado; i++)
            {
                for (int j = 0; j < 20 && !encontrado; j++) 
                {
                    if (tabla[i,j] == 4) 
                    {
                        fila = i;
                        columna = j;
                        encontrado = true;
                    }
                }
            }

            for (int i = 0; i < movimientos.Count; i++)
            {
                Debug.WriteLine(movimientos[i]);
                laFila = (movimientos[i] / 20);
                laCol = (movimientos[i] - (20 * laFila));
                llenarCuadrado(columna * 19, fila * 19, tablaOriginal[fila,columna]);
                llenarCuadrado(laCol * 19, laFila * 19, 4);
                fila = laFila;
                columna = laCol;
                Thread.Sleep(100);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int persona = 0;
            int salida = 0;
            celdasMarcadas = 0;
            for (int fila = 0; fila < 20; fila++)
            {
                for (int columna = 0; columna < 20; columna++)
                {
                    if (tabla[fila, columna] == 1 || tabla[fila, columna] == 2 || tabla[fila, columna] == 3 || tabla[fila, columna] == 4 || tabla[fila, columna] == 5)
                    {
                        celdasMarcadas++;
                    }
                    if (tabla[fila, columna] == 4)
                    {
                        persona++;
                    }
                    if (tabla[fila, columna] == 5)
                    {
                        salida++;
                    }
                }
            }            
            if (celdasMarcadas == 0)
            {
                MessageBox.Show("El patrón esta en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (persona == 1)
                {
                    if (salida > 0)
                    {
                        labelEstadoP.Text = "Estado: Calculando ruta más cercana...";
                        Controlador controlador = new Controlador();
                        controlador.setValores(0, Convert.ToDouble(tbxBajo.Text));
                        controlador.setValores(1, Convert.ToDouble(tbxMedio.Text));
                        controlador.setValores(2, Convert.ToDouble(tbxAlto.Text));

                        vectorMovimientos = controlador.iniciar(tabla, salida);
                        labelEstadoP.Text = "";
                        btnSimulacion.Enabled = true;
                        btnCalcular.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Dibuje al menos una salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Dibuje una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



       
    }
}