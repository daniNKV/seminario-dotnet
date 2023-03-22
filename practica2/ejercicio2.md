Sea el siguiente código:

 ` ` `
    object o1 = "A";
    object o2 = o1;
    o2 = "Z";
    Console.WriteLine(o1 + " " + o2);
 ` ` `  
 
El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
consola no sea “Z Z”?

RTA: Al asignarle a o2 la referencia al objeto o1, ambos objetos están apuntando hacia el contenido de o1. Luego, al asignarle a o2 un nuevo valor, el valor de o2 es casteado implicitamente hacia el tipo char/string. Dejando de ser la referencia al objeto o1. No significa que el objeto o2 cambie el valor de o1.