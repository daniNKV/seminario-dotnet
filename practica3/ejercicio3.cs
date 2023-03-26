// Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
// parámetro más que representa la plantilla de formato que debe aplicarse a los números al
// imprimirse. La plantilla de formato es un string de acuerdo a las convenciones de formato
// compuesto, por ejemplo “0.0” implica escribir los valores reales con un dígito para la parte
// decimal.

// void ImprimirMatrizConFormato(double[,] matriz, string formatString)

class Ejercicio3
{
    static void Main(String[] args)
    {
        double[,] matriz = new double[,] 
            {
                {2.0, 1.0, 4.0},
                {4.0, 5.0, 2.5},
                {2.5, 4.6, 1.6}
            };
        ImprimirMatrizConFormato(matriz);
    }
    static void ImprimirMatrizConFormato(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1) ; j++) {
                double valor = matriz[j,i];
                Console.Write($"{valor:0.0}" + " ");
            }
        Console.WriteLine();
        }

    }
}