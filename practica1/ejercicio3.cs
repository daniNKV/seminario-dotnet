/* El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente
 fragmento de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para
que el programa siga funcionando de igual manera */

/*
string st = @"c:\windows\system";
         Console.WriteLine(st);
*/

// Agrega el carácter \ para escapar la barra inversa 
string st = "c:\\windows\\system";
         Console.WriteLine(st);