using segundo_parcial_progra.CLASE_NOTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundo_parcial_progra
{
    class promedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            string[,] alumnos = new string[1, 2];

            int real;
            int mayor = 0;
            int totalfila = matriz.GetLength(0);
            int filaseccion = totalfila;
            int totalcolum = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, CLSENUMCOLUM.Sección] == seccion)
                {

                    real = Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial1])
                            + Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial2])
                            + Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial3]);



                    if (mayor > real)
                    {
                        alumnos[0, 1] = mayor.ToString();

                    }
                    else
                    {
                        alumnos[0, 0] = matriz[fila, CLSENUMCOLUM.Nombre];
                        alumnos[0, 1] = real.ToString();
                        mayor = real;
                    }



                }


            }

            return alumnos;
        }

        public string nombre_nota_mayor(string[,] matriz, string sección)
        {
            string nom = "";
            int real;
            int mayor = 0;
            int totalfila = matriz.GetLength(0);
            int filaseccion = totalfila;
            int totalcolum = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)


            {

                int Par1 = Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial1]);
                int Par2 = Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial2]);
                int Par3 = Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial3]);

                real = (Par1 + Par2 + Par3) / 3;

                if (real > mayor)
                {
                    nom = matriz[fila, CLSENUMCOLUM.Nombre];
                    mayor = real;
                }
            }

            return nom;


        }

        public int promedios_general_sección(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int Promedio;
            int totalfila = matriz.GetLength(0);
            int filasseccion = totalfila;
            int totalcolum = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, CLSENUMCOLUM.Sección] == seccion)
                {
                    acumulador = acumulador
                        + Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial1])
                        + Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial2])
                        + Convert.ToInt32(matriz[fila, CLSENUMCOLUM.Parcial3]);
                }
                else
                {
                    filasseccion--;
                }

            }

            Promedio = (acumulador / (filasseccion - 1)) / 3;
            return Promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int Promedio;
            int totalfila = matriz.GetLength(0);
            int filasseccion = totalfila;
            int totalcolum = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Promedio = acumulador / (totalfila - 1);
            return Promedio;
        }

        public int promedios_por_sección(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int Promedio;
            int totalfila = matriz.GetLength(0);
            int filasseccion = totalfila;
            int totalcolum = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, CLSENUMCOLUM.Sección] == seccion)
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);


                }
                else
                {
                    filasseccion--;
                }

            }
            Promedio = acumulador / (filasseccion - 1);
            return Promedio; 


        }

        internal int promedios_general_sección(string[,] arregloDosDimensiones, string v)
        {
            throw new NotImplementedException();
        }

        internal string nombre_nota_mayor(string[,] arregloDosDimensiones)
        {
            throw new NotImplementedException();
        }
    }
    }
    

