/*
 Escribir un programa que calcule la suma de dos números reales introducidos por teclado y
muestre el resultado en la consola (utilizar double.Parse(st) para obtener el valor double a
partir del string st.
*/

double x1, x2;

Console.WriteLine("Ingrese un número real: ");
x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número real: ");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine(x1 + x2);