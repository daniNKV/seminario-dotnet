Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente?
        
` ` ` 
int sum = 0;
int i = 1;
while (i <= 10);
{
    sum += i++;
}
` ` ` 

// 1 - i = 2 sum = 2
// 2 - i = 3 sum = 5
// 3 - i = 4 sum = 9
// 4 - i = 5 sum = 13
// 5 - i = 6 sum = 19
// 6 - i = 7 sum = 26
// 7 - i = 8 sum = 34
// 8 - i = 9 sum = 43
// 9 - i = 10 sum = 53
...

El primer error se encuentra en el punto y coma de la sentencia while, haciendo que el codigo se ejecute infinitamente. Ya que los bloques de código { ... } son validos en c#.

El segundo error se encuentra en que no considera al numero 1 dentro de la sumatoria. En la primera iteracion, comienza desde el numero 2 en lugar de realizar la operacion 1 + 2. Realiza la sumatoria de 2 a 10,.