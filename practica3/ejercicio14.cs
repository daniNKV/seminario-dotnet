// Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base
// 10 a otra base realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario
// dividimos sucesivamente por dos hasta encontrar un cociente menor que el divisor, luego el
// resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por
// todos los restos.

class Ejercicio14
{
    // static void Main(string[] args) 
    // {
    //     Console.WriteLine(CambiarBase(35, 2));
    // }
    static int CambiarBase(int valor, int nuevaBase)
    {
        Stack<int> restos = new Stack<int>();
        int cociente;
        do {
            cociente = valor / nuevaBase;
            restos.Push(valor % nuevaBase);
            valor = cociente;
        } while (cociente > nuevaBase);
        
        restos.Push(valor % nuevaBase);
        cociente = valor / nuevaBase;

        int[] restosArr = restos.ToArray();
        
        string res = cociente.ToString() + String.Join("", restosArr);

        return Int32.Parse(res);
    }
}