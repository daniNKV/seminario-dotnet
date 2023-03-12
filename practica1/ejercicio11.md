Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y
contestar las preguntas.
```
Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
```

¿Qué se puede concluir respecto del operador de división “/” ?
Cuando ambos operandos son enteros, su resultado es únicamente entero, sin tomar en cambio el resto de división. En cambio, si alguno de ellos es float/decimal, 
el resultado es expresado en float/decimal.

 ¿Cómo funciona el operador + entre un string y un dato numérico?
Concatena el string pasado con el dato númerico parseado en String, por ej: "unTexto" + 10 resulta en unTexto10