Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros
cuando se invoca desde la línea de comandos.

` ` ` 
Console.WriteLine("¡Hola {0}!", args[0])
` ` ` 

Lo único que sucede, es que se pasa al método un array de argumentos vació. En la posición 0 hay un valor null.