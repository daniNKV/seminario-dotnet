// Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices
// pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo
// tamaño, en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de
// columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una
// excepción ArgumentException.
// double[,]? Suma(double[,] A, double[,] B)
// double[,]? Resta(double[,] A, double[,] B)
// double[,] Multiplicacion(double[,] A, double[,] B)

class Ejercicio6
{
    static double[,]? SumaMatrices(double[,] matriz1, double[,] matriz2)
    {
        if (matriz1.GetLength(0) != matriz2.GetLength(0) && matriz1.GetLength(1) != matriz2.GetLength(1)) {
            return null;
        } else {
            for (int i = 0; i < matriz1.GetLength(0); i++) {
                for (int j = 0; i < matriz1.GetLength(1); j++) {
                    matriz1[i,j] = matriz1[i,j] + matriz2[i,j];
                }
            }

            return matriz1;
        }
    }

    static double[,]? RestaMatrices(double[,] matriz1, double[,] matriz2)
    {
        if (matriz1.GetLength(0) != matriz2.GetLength(0) && matriz1.GetLength(1) != matriz2.GetLength(1)) {
            return null;
        } else {
            for (int i = 0; i < matriz1.GetLength(0); i++) {
                for (int j = 0; i < matriz1.GetLength(1); j++) {
                    matriz1[i,j] = matriz1[i,j] - matriz2[i,j];
                }
            }

            return matriz1;
        }
    }

    static double[,]? MultiplicarMatrices(double[,] matriz1, double[,] matriz2)
    {
        try {
            for (int i = 0; i < matriz1.GetLength(0); i++) {
                for (int j = 0; i < matriz1.GetLength(1); j++) {
                    matriz1[i,j] = matriz1[i,j] * matriz2[i,j];
                }
            }
                
            return matriz1;

        } catch (ArgumentException e) {
            throw new ArgumentException();
        }
    }
    
}