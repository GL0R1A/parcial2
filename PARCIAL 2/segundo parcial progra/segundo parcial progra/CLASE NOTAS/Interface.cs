using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial_progra.CLASE_NOTAS
{
    interface Interface
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);

        /// <summary>
        /// retorna el promedio de un parcial en especial y una sección en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>

        int promedios_por_sección(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        ///  Saca el promedio general por alumnos por sección
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns> 

        int promedios_general_sección(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// retorna una matriz de 2 columnas con el nombre y la otra columna es la sumatoria del parcial del 1 al 3
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>

        string[,] Clasificar_Alumnos(string[,] matriz,string sección);
        /// <summary>
        /// busca el mejor promedio general o por sección
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>


        string nombre_nota_mayor(string[,] matriz);

        string nombre_nota_mayor(string[,] matriz, string sección);
    }
}
