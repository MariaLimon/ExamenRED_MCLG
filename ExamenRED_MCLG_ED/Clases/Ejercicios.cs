using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRED_MCLG_ED.Clases
{
    internal class Ejercicios
    {
        public void TablaVendedores()
        {
            int[,] tablaGanancias =
            {{500, 3000, 100, 400 },
            {1000, 150,200,500 },
            {250, 1800, 2900,300 },
            {400,130,90,2400 },
            {60,20,4000,3600 }};

            for (int i = 0; i < tablaGanancias.GetLength(0); i++)
            {
                for (int j = 0; j < tablaGanancias.GetLength(1); j++)
                {
                    Console.WriteLine(tablaGanancias[i,j]);
                }
               
            }
            int[] vendedores = new int[4];
            int[] productos = new int[5];

            for (int i = 0; i < tablaGanancias.GetLength(0); i++)
            {
                for (int j = 0; j < tablaGanancias.GetLength(1); j++)
                {
                    switch (i)
                    {
                        case 0:
                            productos[0] += tablaGanancias[i, j];
                            break;
                        case 1:
                            productos[1] += tablaGanancias[i, j];
                            break;
                        case 2:
                            productos[2] += tablaGanancias[i, j];
                            break;
                        case 3:
                            productos[3] += tablaGanancias[i, j];
                            break;
                        case 4:
                            productos[4] += tablaGanancias[i, j];
                            break;
                    }
                    switch (j)
                    {
                        case 0:
                            vendedores[0] += tablaGanancias[i, j];
                            break;
                        case 1:
                            vendedores[1] += tablaGanancias[i, j];
                            break;
                        case 2:
                            vendedores[2] += tablaGanancias[i, j];
                            break;
                        case 3:
                            vendedores[3] += tablaGanancias[i, j];
                            break;
                        
                    }
                }
            }

            for (int x = 0; x < vendedores.Length; x++)
            {
                Console.WriteLine($"total del vendedor {x+1} = {vendedores[x]}");
            }
            Console.WriteLine("-----------------------");
            for (int z = 0; z <= tablaGanancias.GetLength(1); z++)
            {
                Console.WriteLine($"total del producto {z } = {productos[z]}");
            }
        }





        public void Matriz()
        {
            int[] matriz = new int[10];
            Random random= new Random();

            Console.WriteLine("Matriz desordenada");
            for (int i = 0; i<matriz.Length;i++)
            {
                matriz[i] = random.Next(100);
                Console.WriteLine(string.Join (" ",matriz[i]));
            }


            Console.WriteLine("Matriz ordenada");
            //ordenar desendente
            int actual;

            for(int i = 0; i <matriz.Length; i++)
            {
                for(int j=0;j <matriz.Length -1; j++)
                {
                    if (matriz[i] >= matriz[j])
                    {
                        actual = matriz[i];
                        matriz[i] = matriz[j];
                        matriz[j] = actual;
                    }
                }
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matriz[i]));
            }

            int objetivo = 75;
            int centinela = -1;
            for(int i = 0; i < matriz.Length; i++)
            {
                if(matriz[i] == objetivo)
                {
                    centinela = i;
                    break;
                }
                else
                {
                    centinela = -1;
                }
            }
            if(centinela != -1)
            {
                Console.WriteLine($"el {objetivo} esta en la posicion {centinela+1} de la matriz");
            }
            else
            {
                Console.WriteLine($"el {objetivo} no esta en la matriz");
            }
            
            
        }




        public void Curp(string cadenaCurp)
        {
            
            string cadenaHoM = cadenaCurp.Substring(10,1);
            if (cadenaHoM == "M" || cadenaHoM == "m")
            {
                Console.WriteLine("Usted es del sexo femenino");
            }
            else if(cadenaHoM == "H" || cadenaHoM == "h")
            {
                Console.WriteLine("Usted es del sexo masculino");
            }
            else
            {
                Console.WriteLine("No es posible leer su sexo");
            }
            string year = cadenaCurp.Substring(4, 2);
            string mes = cadenaCurp.Substring(6, 2);
            string dia = cadenaCurp.Substring(8, 2);

            if(Convert.ToInt16(year) < 23)
            {
                Console.WriteLine($"su fecha de nacimiento es {dia}/{mes}/20{year}");
            }
            else
            {
                Console.WriteLine($"su fecha de nacimiento es {dia}/{mes}/19{year}");
            }
        }
    }
}
