/*
Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
línea en blanco. Para ingresar un string desde el teclado utilizar Console.ReadLine()
*/

Console.WriteLine("Ingrese su nombre: ");

// El caracter ? indica que la variable puede ser nula
string? nombreUsuario = Console.ReadLine();

if (nombreUsuario != "") {
    Console.WriteLine(nombreUsuario);
} else {
    Console.WriteLine("Hola Mundo");
}

