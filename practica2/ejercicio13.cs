// Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
// a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
// noviembre, octubre ..., enero)
// c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
// nombre de un mes
// Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses

class ejercicio12 
{
    enum Meses 
    {
        Enero,
        Febrero,
        Marzo,
        Abril,
        Mayo,
        Junio,
        Julio,
        Agosto,
        Septiembre,
        Octubre,
        Noviembre,
        Diciembre
    }
    static void ListarMeses()
    {
        string[] meses = Enum.GetNames(typeof(Meses));

        for (int i=meses.Length; i > 0; i--) { 
            Console.WriteLine(meses[i]);
        }
    }

    static void CheckMes()
    {
        Console.Write("Ingrese un mes");
        string? mesBuscado = Console.ReadLine();
        string[] meses = Enum.GetNames(typeof(Meses));

        foreach(string mes in meses){
            if(mesBuscado == mes ) {
                Console.WriteLine("Encontrado");
            }else {
                Console.WriteLine("No encontrado");
            }
        }
    }
}