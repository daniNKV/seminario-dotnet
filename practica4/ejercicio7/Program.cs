// 7) Codificar la clase Nodo de un árbol binario de búsqueda de valores enteros. Un árbol binario de búsqueda no
// tiene valores duplicados y el valor de un nodo cualquiera es mayor a todos los valores de su subárbol izquierdo
// y es menor a todos los valores de su subárbol derecho.
// Desarrollar los métodos:
// 1. Insertar(valor): Inserta valor en el árbol descartándolo en caso que ya exista.
// 2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
// 3. GetAltura(): devuelve la altura del árbol.
// 4. GetCantNodos(): devuelve la cantidad de nodos que posee el árbol.
// 5. GetValorMáximo(): devuelve el valor máximo que contiene el árbol.
// 6. GetValorMínimo(): devuelve el valor mínimo que contiene el árbol.
// A modo de ejemplo, el siguiente código debe arrojar por consola la salida que se muestra.

// Nodo n = new Nodo(7);
// n.Insertar(8);
// n.Insertar(10);
// n.Insertar(3);
// n.Insertar(1);
// n.Insertar(5);
// n.Insertar(14);
// foreach (int i in n.GetInOrden())
// {
// Console.Write(i + " ");
// }
// Console.WriteLine();
// Console.WriteLine(n.GetAltura());
// Console.WriteLine(n.GetCantidadNodos());
// Console.WriteLine(n.GetValorMaximo());
// Console.WriteLine(n.GetValorMinimo());