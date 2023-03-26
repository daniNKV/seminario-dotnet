// Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la
// matriz pasada como parámetro:
// double[][] GetArregloDeArreglo(double [,] matriz)

class Ejercicio5 
{
    static double[][] GetArregloDeArreglo(double [,] matriz)
    {
        double[][] nuevoArreglo = new double[matriz.GetLength(0)][matriz.GetLength[1]];

        for(int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; i < matriz.GetLength(1); i++) {
                nuevoArreglo[i][j] = matriz[i][j];
            }
        }

        return nuevoArreglo;
    }
}