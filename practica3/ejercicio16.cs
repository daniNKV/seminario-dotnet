// Implementar un programa que permita al usuario ingresar números por la consola. Debe
// ingresarse un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía.
// A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma
// acumulada de los mismos. Utilizar la instrucción try/catch para validar que la entrada
// ingresada sea un número válido, en caso contrario advertir con un mensaje al usuario y
// proseguir con el ingreso de datos

class Ejercicio16
{

    static void Main(string[] args)
    {
        int res = SumarNumeros();

        Console.WriteLine(res);
    }
    static int SumarNumeros() 
    {
        int suma = 0;

        string leido = LeerNumero();

        while (leido.Length != 0) {
            suma += Int32.Parse(leido);
            leido = LeerNumero();
        }

        return suma;

    }

    static string LeerNumero()
    {
        try {
            Console.WriteLine("Ingrese un número o enter para terminar");
            string leido = Console.ReadLine();
            ValidarNumero(leido);

            return leido;

        } catch (Exception e) {
            Console.WriteLine(e.Message);

            return "0";
        }


    }

    static void ValidarNumero(string numero)
    {   
        int num;
        if (!Int32.TryParse(numero, out num) && numero != "") {
            throw new Exception("El valor ingresado no es un número");
       }
    }
}