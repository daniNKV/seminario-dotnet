/*
Escribir un programa que imprima en la consola todos los números que sean múltiplos de 17 o
de 29 comprendidos entre 1 y 1000
*/

for(int i = 1; i < 1000; i++) {
    if (i % 17 == 0 || i % 29 == 0) {
        Console.WriteLine(i); 
    }
}