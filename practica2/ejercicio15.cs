// Escribir una función (método int Fib(int n)) que calcule el término nde la serie de
// Fibonacci.
// Fib(n) = 1, si n <=2
// Fib(n) = Fib(n-1) + Fib(n-2), si n > 2

class Ejercicio15
{

    // public static void Main(string[] args)
    // {
    //     Console.Write(calcularFibonacci(10));
    // }
    static int calcularFibonacci(int n)
    {
        int[] serie = new int[n];

        if (n <= 2) {
            return 1;
        }

        serie[0] = 0;
        serie[1] = 1;

        for (int i = 2; i < n; i++) {
            
            serie[i] = serie[i - 1] + serie[i - 2];

        }

        return serie[n-1];
    }
}