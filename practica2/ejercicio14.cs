// Implementar un programa que muestre todos los números primos entre 1 y un número natural
// dado (pasado al programa como argumento por la línea de comandos). Definir el método bool
// EsPrimo(int n) que devuelve true sólo si nes primo. Esta función debe comprobar si nes
// divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d)
// devuelve la raíz cuadrada de d)

using System;

class Ejercicio14
{
    public static void Main(string[] args)
    {
        int num = Int32.Parse(args[0]);

        ListarPrimos(num);
    }
    static void ListarPrimos(int n)
    {
        for(int i = 1; i <= n; i++) {
            if (EsPrimo(i)) {
                Console.Write(i + " ");
            }
        }
    }

    static bool EsPrimo(int n) {
        bool esPrimo = true;

        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                esPrimo = false;

            }
        }

        return esPrimo;
    }
}