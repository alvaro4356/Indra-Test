using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine();

            Console.Write("Tamaño de la matriz: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[,] MAT = new int[cantidad + 1, cantidad + 1];
            int[,] MATT = new int[cantidad + 1, cantidad + 1];

            // Generamos los valores de la matriz
            Random rnd = new Random();
            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= cantidad; j++)
                {
                    MAT[i, j] = rnd.Next(0, 100);
                    Console.SetCursorPosition(j * 4, i + 5);
                    Console.Write(MAT[i, j]);
                }
            }

            // proceso de transponer los valores
            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= cantidad; j++)
                {
                    MATT[i, j] = MAT[j, i];
                }
            }

            // Mostramos la salida
            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= cantidad; j++)
                {
                    Console.SetCursorPosition(j * 4, i + 12);
                    Console.Write(MATT[i, j]);
                }
            }
            int mayor = MAT[0, 0];
            int menor = MAT[0, 0];
            for (int i = 0; i <= cantidad; i++)
            {
                for (int j = 0; j <= cantidad; j++)
                {
                    if (MAT[i, j] > mayor)

                        mayor = MAT[i, j];

                    else
                    {
                        if (MAT[i, j] < menor)

                            menor = MAT[i, j];

                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("El valor máximo es: " + mayor);

            Console.WriteLine("La valor mínimo es: " + menor);
            Console.WriteLine();
            Console.ReadLine();
        }
       
    }
}
