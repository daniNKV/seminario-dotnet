
¿Qué hace la instrucción

` ` ` 
     
int[]? vector = new int[0];

` ` ` 

La instrucción crea una variable llamada vector, conteniendo un array de enteros y lo instancia con longitud 0.

¿asigna a la variable vector el valor null? 

El hecho de que sea nullable reference type no le asigna el null, sino que admite que pueda ser nulo. En este caso, el array es un array vacio, no nulo. Sería nulo si la variable no estaría referenciando a ningún objeto.


