// Escribir una función (método int Fac(int n)) que calcule el factorial de un número n
// pasado al programa como parámetro por la línea de comando
// a) Definiendo una función no recursiva
// b) Definiendo una función recursiva
// c) idem a b) pero con expression-bodiedmethods(Tip: utilizar el operador condicional
// ternario

class Ejercicio16
{
    public static void Main(string[] args)
    {
        // Console.Write(CalcularFactorialA(Int32.Parse(args[0])));
        Console.Write(CalcularFactorialB(4));
    }
    static int CalcularFactorialA(int n) {
        int acc = 1;
        for (int i = 1; i <= n; i++){
            acc *= i;
        }

        return acc;
    }

    static int CalcularFactorialB(int n){
        if (n < 1) {
            return 1;
        }

        return n * CalcularFactorialB(n - 1);
    }

    static int CalcularFactorialC(int n) => (n < 1) ? 1 : (n * CalcularFactorialC(n - 1));
    
}