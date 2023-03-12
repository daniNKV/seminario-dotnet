Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
```
Console.WriteLine(st=Console.ReadLine());?
```
La instrucción es válida debido a que la variable se declara por fuera de los parámetros del método. 
Por lo tanto es válido asignar y pasar el parámetro de forma simultanea, pero no declarar la variable,
por ejemplo, es inválido lo siguiente: 
```
Console.WriteLine(string st = Console.ReadLine());
```