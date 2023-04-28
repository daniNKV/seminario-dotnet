Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();
PeliculaClasica peliculaClasica = new PeliculaClasica();
Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);
Procesador.Atender(persona);
Procesador.Atender(perro);
Procesador.Devolver(pelicula, persona);
Procesador.Devolver(libro, persona);
Procesador.Lavar(auto);
Procesador.Lavar(perro);
Procesador.Reciclar(libro);
Procesador.Reciclar(auto);
Procesador.Secar(auto);
Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);
Procesador.Vender(peliculaClasica, persona);

var lista = new List<object>() {
    new Persona(),
    new Auto()
};
foreach (IComercial c in lista) {
    c.Importar();    
}
foreach (IImportante i in lista) {
    i.Importar();
}
(lista[0] as Persona)?.Importar();
(lista[1] as Auto)?.Importar();
