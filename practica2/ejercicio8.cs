// Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un
// saludo personalizado para cada uno de ellos.
// a) utilizando la sentencia for
// b) utilizando la sentencia foreach

class Ejercicio8
{
    static void Saludos(string[] nombres) 
    {
        for(int i = 0; i < nombres.Length; i++ ){
            Console.println("Hola " + nombre[i]);
        }
    }

    static void Saludos2(string[] nombres)
    {
        foreach(string nombre in nombres){
            Console.println("Hola " + nombre);
        }
    }
}