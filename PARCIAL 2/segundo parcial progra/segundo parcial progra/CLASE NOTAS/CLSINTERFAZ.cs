using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial_progra.CLASE_NOTAS
{
    class CLSINTERFAZ : Interface
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string sección)
        {
            throw new NotImplementedException();
        }

        public string nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }

        public string nombre_nota_mayor(string[,] matriz, string sección)
        {
            throw new NotImplementedException();
        }

        public int promedios_general_sección(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int promedio;
            int totalfila = matriz.GetLength(0);
            int totalcolumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedio = acumulador / (totalfila - 1);
            return promedio;
        }
                


        public int promedios_por_sección(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int promedio;
            int totalfila = matriz.GetLength(0);
            int totalcolumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedio = acumulador / (totalfila - 1);
            return promedio;
        }
         
        }
    }

