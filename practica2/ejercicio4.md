¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
     
` ` ` 

Console.WriteLine(args == null);
Console.WriteLine(args.Length)

` ` ` 

La salida es es false y 0. Se debe a que el array de argumentos es pasado igual al método, por lo que la referencia existe y es no nula. La longitud viene a ser 0.