17.
Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
expresión (tip: observar qué pasa cuando b = 0):

```
if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
```

RTA: El operador "&" no es de circuito corto, por lo que evalúa ambas condiciones aunque la de la izquierda de falso.
A diferencia de "&&" que si la expresión de la izquierda es falsa, no evalua la derecha. La solución es usar este operador.

18.
Utilizar el operador ternario condicional para establecer el contenido de una variable entera con
el menor valor de otras dos variables enteras.

RTA:
```
a < b ? c = a : c = b;
```

19.
¿Cuál es la salida por consola del siguiente código?
```
for (int i = 0; i <= 4; i++) {
    string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
    Console.WriteLine(st);
}
```

RTA: "< 1" "uno" "dos" "tres" "> 3"