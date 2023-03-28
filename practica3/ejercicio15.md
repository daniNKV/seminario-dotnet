¿Qué salida por la consola produce el siguiente código?


```

int x = 0;
try
{
Console.WriteLine(1.0 / x); // Infinito
Console.WriteLine(1 / x); // Exception: Attempted to divide by zero
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}

```
¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los
operandos?

En datos de tipo punto flotante, resuelve mostrar el límite de la operación, infinitos o NaN. Debido a la posibilidad de guardarlos en valores reservados dentro del estándar de doble precisión. En enteros, muestra una excepción.