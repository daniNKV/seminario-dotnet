// ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
// las palabras (una por línea) de una frase ingresada por consola por el usuario

// Split es un método de la clase String, que retorna un array con las substrings
// de la instancia string desde la cual fue llamado, usando un delimitador
// ingresado como parámetro

class ejercicio8
{
    static void partirString(string frase)
    {
        string[] palabras = frase.Split(' ');

        foreach(string palabra in palabras) {
            Console.Write(palabra);
        }
    }
}