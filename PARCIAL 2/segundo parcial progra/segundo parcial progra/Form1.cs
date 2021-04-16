using segundo_parcial_progra.CLASE_NOTAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundo_parcial_progra
{
    public partial class Form1 : Form
    {
        private string[] arreglonotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            clsarchivos ar = new clsarchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\mita\Documents\ARCHIVOS PLANOS";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                arreglonotas = ar.LeerArchivo(archivo);
                textBox1resultado.Text = resultado;

            }
        }
        private int Fncpromedios(string[,] matriz, int columna)
        {
            limpiar();
            int acumulador = 0;
            int promedio;
            int totalfilas = matriz.GetLength(1);
            for (int fila = 1; fila < totalfilas;fila++)
            {
                acumulador = acumulador / matriz.GetLength(0);
            }
            promedio = acumulador / (totalfilas - 1);
            return promedio;

           
 
}
        private void button1nombres_Click(object sender, EventArgs e)
        {
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length,6];


            int NumeroLinea = 0;
            foreach (string linea in arreglonotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = datosUnitarios[5];
               

                NumeroLinea++;


               listBox1resultado.Items.Add($"{datosUnitarios[CLSENUMCOLUM.Nombre]} nota :{datosUnitarios[CLSENUMCOLUM.Parcial2 ]}");
            }
            int promedio = Fncpromedios(ArregloDosDimensiones,2);
             MessageBox.Show($"el promedio del parcial 2");
            promedio = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            limpiar();
            CLSINTERFAZ promedio = new CLSINTERFAZ();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {
                string[] DatosUnitarios = linea.Split(';');

                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                NumeroLinea++;
            }
            int Promedio1 = promedio.promedios_por_parcial(ArregloDosDimensiones, 2);
            int Promedio2 = promedio.promedios_por_parcial(ArregloDosDimensiones, 3);
            int Promedio3 = promedio.promedios_por_parcial(ArregloDosDimensiones, 4);
            listBox1resultado.Items.Add($"  EL Promedio del PRIMER Parcial: {Promedio1}");
            listBox1resultado.Items.Add($" El Promedio de Segundo Parcial: {Promedio2}");
            listBox1resultado.Items.Add($" El Promedio de TERCERO Parcial: {Promedio3}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            promedio promedio = new promedio();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int proseApar1 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial1, "A");
            int proseApar2 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial2, "A");
            int proseApar3 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial3, "A");
            int proseBpar1 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial1, "B");
            int proseBpar2 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial2, "B");
            int proseBpar3 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial3, "B");
            int proseCpar1 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial1, "C");
            int proseCpar2 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial2, "C");
            int proseCpar3 = promedio.promedios_por_sección(ArregloDosDimensiones, CLSENUMCOLUM.Parcial3, "C");

            listBox1resultado.Items.Add($"Promedio Sección A, Parcial 1: {proseApar1}");
            listBox1resultado.Items.Add($"Promedio Sección A, Parcial 2: {proseApar2}");
            listBox1resultado.Items.Add($"Promedio Sección A, Parcial 3: {proseApar3}");

            listBox1resultado.Items.Add($"Promedio Sección B, Parcial 1: {proseBpar1}");
            listBox1resultado.Items.Add($"Promedio Sección B, Parcial 2: {proseBpar2}");
            listBox1resultado.Items.Add($"Promedio Sección B, Parcial 3: {proseBpar3}");

            listBox1resultado.Items.Add($"Promedio Sección C, Parcial 1: {proseCpar1}");
            listBox1resultado.Items.Add($"Promedio Sección C, Parcial 2: {proseCpar2}");
            listBox1resultado.Items.Add($"Promedio Sección C, Parcial 3: {proseCpar3}");


        }

        private void button3GENERALSEC_Click(object sender, EventArgs e)
        {
            limpiar();
            promedio promedio = new promedio();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promegeA = promedio.promedios_general_sección(ArregloDosDimensiones, "A");
            int promegeB = promedio.promedios_general_sección(ArregloDosDimensiones, "B");
            int promegeC = promedio.promedios_general_sección(ArregloDosDimensiones, "C");

            listBox1resultado.Items.Add($"Promedio General Sección A: {promegeA}");
            listBox1resultado.Items.Add($"Promedio General Sección B: {promegeB}");
            listBox1resultado.Items.Add($"Promedio General Sección C: {promegeC}");
        }

        private void button6CLASIALUM_Click(object sender, EventArgs e)
        {
            limpiar();
            promedio promedio = new promedio();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string[,] alumclasi = promedio.Clasificar_Alumnos(ArregloDosDimensiones, "A");
            string nombre = alumclasi[0, 0];
            string nota = alumclasi[0, 1];

            listBox1resultado.Items.Add($" LOS ALUMNOS CON MEJORES NOTAS ");
            listBox1resultado.Items.Add($"SECCIÓN A:");
            listBox1resultado.Items.Add($"Nombre: {nombre}");
            listBox1resultado.Items.Add($"Suma de  parciales: {nota}");
        }
 
        private void button4NOTAMAX_Click(object sender, EventArgs e)
        {
            limpiar();
            promedio promedio = new promedio();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string maximo = promedio.nombre_nota_mayor(ArregloDosDimensiones, "B");

            listBox1resultado.Items.Add($" ... EL ALUMNO CON PROMEDIO MAYOR SECCIÓN B ...");
            listBox1resultado.Items.Add($"Nombre: {maximo}");
        }

        private void button8NOTAMAXIMAGENE_Click(object sender, EventArgs e)
        {
            limpiar();
            promedio promedio = new promedio();
            string[,] ArregloDosDimensiones = new string[arreglonotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in arreglonotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Parcial3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, CLSENUMCOLUM.Sección] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string maxima = promedio.nombre_nota_mayor(ArregloDosDimensiones);

            listBox1resultado.Items.Add($" --- ALUMNO CON PROMEDIO MAYOR ---");
            listBox1resultado.Items.Add($"Nombre: {maxima}");
        }

        private void limpiar()
        {
            listBox1resultado.Items.Clear();
        }
    }
    }

     
    

    
                 