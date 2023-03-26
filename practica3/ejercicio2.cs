// Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo
// de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en
// la misma línea en la consola.
// Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la
// dimensión i.
// void ImprimirMatriz(double[,] matriz)

class Ejercicio2
{
    static void Main(String[] args)
    {
        double[,] matriz = new double[,] 
            {
                {2.0, 1.0, 4.0},
                {4.0, 5.0, 2.5},
                {2.5, 4.6, 1.6}
            };
        Ejercicio2.ImprimirMatriz(matriz);
    }
    static void ImprimirMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1) ; j++) {
                Console.Write(matriz[j,i] + " ");
            }
            Console.WriteLine();
        }

    }
}