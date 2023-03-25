// Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
// circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
// un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
// StringBuilder en lugar de string y otro en el que no

// Los objetos de la clase String son inmutables, por lo que al llamar cualquier método sobre un string,
// genera nuevos objetos con valores y direcciones diferentes, significando una disminución en la performance.
// En cambio, la clase StringBuilder genera objetos mutables, pudiendo ser modificados, contando con un buffer
// para acomodar las expansiones del string, hasta alcanzar su tope, pudiendose generar otro buffer para los nuevos cambios.

// Casos de uso StringBuilder:
//      -Gran número de cambios sobre una string
//      -Gran número y desconocido de operaciones de concatenación para que el compilador las unifique.
//      -Al tener que realizar pocas búsquedas extensivas durante la creación de un string


// Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
// // implementados en el ejercicio anterior
class ejercicio9
{
    static void pruebaStrings()
    {   
        DateTime init = DateTime.Now;
        string uno = "";
        for(int i = 0; i < 10000; i++) {
             string.Concat("asd", uno);
        }
        DateTime finished = DateTime.Now;

        Console.Write(finished - init);
    }
    static void pruebaStringBuilders()
    {
        DateTime init = DateTime.Now;

        string uno = "";
        for(int i = 0; i < 10000; i++) {
             string.Concat("asd", uno);
        }

        DateTime finished = DateTime.Now;

        Console.Write(finished - init);


    }
}