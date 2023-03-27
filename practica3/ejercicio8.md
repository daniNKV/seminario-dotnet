¿Qué líneas del siguiente método provocan error de compilación y por qué?
```

var a = 3L; // variable long
dynamic b = 32; 
object obj = 3; // boxing desde int 
a = a * 2.0; 
b = b * 2.0; 
b = "hola"; // b es dynamic, acepta cambio de tipo
obj = b; // boxing desde string
b = b + 11; 
obj = obj + 11; // ERROR
// Tipos anónimos
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22;
d = c; // ERROR
e = d; // ERROR
f = e; // ERROR

```
