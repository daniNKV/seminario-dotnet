// 1) Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un algoritmo que permita al
// usuario ingresar en una consola una serie de datos de la forma Nombre,Documento,Edad<ENTER>. Una vez
// finalizada la entrada de datos, el programa debe imprimir en la consola un listado con 4 columnas de la
// siguiente forma:
// Nro)  Nombre       Edad      DNI.
// Ejemplo de listado por consola:
// 1)  Juan Perez       40 2098745
// 2)  José García      41 1965412
// ...
// NOTA: Puede utilizar: Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));
// para cambiar la entrada estándar de la consola y poder leer directamente desde un archivo de texto.
// 2) Modificar el programa anterior haciendo privados todos los campos. Definir un constructor adecuado y un
// método público Imprimir() que escriba en la consola los campos del objeto con el formato requerido para el
// listado.
// 3) Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la persona que
// recibe el mensaje tiene más edad que la persona enviada como parámetro. Utilizarlo para realizar un programa
// que devuelva la persona más jóven de la lista.


// ############ RESOLUCIÓN ###############

// List<Persona> personas = LeerPersonas();

// ImprimirListado(personas);

// Persona menorPersona = BuscarMenorPersona(personas);

// ###################################

// List<Persona> LeerPersonas()
// {
//     List<Persona> personas = new List<Persona>();
//     Console.SetIn(new System.IO.StreamReader("entrada.txt"));
//     string? line = Console.ReadLine();
//     while (line != null) {
//         string[] campos = line.Split(",");
//         personas.Add(new Persona(campos[0], Int32.Parse(campos[1]), Int32.Parse(campos[2])));
//         line = Console.ReadLine();
//     }

//     return personas;
// }


// Persona BuscarMenorPersona(List<Persona> personas)
// {
//     Persona menor;
//     Persona[] personasArr = personas.ToArray();
//     for (int i = 1; i < personasArr.GetLength(0) - 1; i++) {
//         if (personasArr[i].EsMayorQue(personasArr[i - 1])){
//             menor = personasArr[i - 1];
//         } else {
//             menor = personasArr[i];
//         }
//     } 

//     return menor;
// }


// void ImprimirListado(List<Persona> personas)
// {
//     Persona[] personasArr = personas.ToArray(); 
//     Console.WriteLine($"Nro) Nombre          Edad   Dni");

//     for (int i = 0; i < personasArr.GetLength(0); i++) {
//         personasArr[i].Imprimir(i);
//     }
// }
