// Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado en un parámetro de salida
// void Fac(int n, out int f)

class Ejercicio17 
{
    void FactorialA(int n, out int f) 
    {
        int acc = 1;

        for (int i = 1; i <= n; i++) {
            acc *= i;
        }

        f = acc;
    }

    void FactorialB(int n, out int f) {
        if (n < 1) {
            f = 1;
        } else {
            int acc;

            FactorialB(n - 1, out acc);

            f = n * acc;
        }

    }
}