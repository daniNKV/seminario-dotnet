// Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que
// devuelven un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la
// matriz no es cuadrada generar una excepción ArgumentException.
// double[] GetDiagonalPrincipal(double[,] matriz)
// double[] GetDiagonalSecundaria(double[,] matriz)

class Ejercicio4
{
    static void Main(String[] args)
    {
        double[,] matriz = new double[,] 
            {
                {2.0, 1.0, 4.0},
                {4.0, 5.0, 2.5},
                {2.5, 4.6, 1.6}
            };
    
        ImprimirDiagonalPrincipal(matriz);
    }
    static void ImprimirDiagonalPrincipal(double[,] matriz)
    {
        try {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                Console.Write(matriz[i, i]);
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }

    static void ImprimirMatrizSecundaria(double[,] matriz)
    {
        try {
            for (int i = matriz.GetLength(0); i > 0 ; i--) {
                Console.Write(matriz[i, i]);
            }
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}