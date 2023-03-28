//  Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
// aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un
// carácter una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. 

// A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que
// la suma fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola
// con los números de la clave encolados y a medida que se desencolen para utilizarlos en el
// cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar y
// otro para descifrar

using System.Text;

class Ejercicio12
{

    // static void Main(string[] args)
    // {   
    //     string str = "Hola Mundo";
    //     int[] clv = new int[] {2,3,1};
    //     string cifrado = Cifrar(str, clv);
    //     Console.WriteLine(Cifrar(str, clv));
    //     Console.WriteLine(Descifrar(cifrado, clv));

    // }

    static string Cifrar(string mensaje, int[] clave)
    {
        byte[] chars = Encoding.ASCII.GetBytes(mensaje);
        Queue<int> claves = GenerarQueueClave(clave, mensaje.Length);

        for (int i = 0; i < chars.Length; i++) 
        // A-65 Z-90 a-97 z-122
        {
            int valor = claves.Dequeue();
            int characterCode = (int)chars[i];
            
            if (characterCode == 32) {
                chars[i] = (byte)(characterCode + valor);

            } else if (characterCode < 91 && characterCode + valor > 90) {
                chars[i] = (byte)((characterCode + valor - 90) + 65);

            } else if (characterCode < 123 && characterCode + valor > 122) {
                chars[i] = (byte)((characterCode + valor - 122) + 97);
    
            } else {
                    chars[i] = (byte)(characterCode + valor);
            }
        }

        return String.Join("", Encoding.ASCII.GetString(chars));
    }

    static private Queue<int> GenerarQueueClave(int[] clave, int cantidadCaracteres)
    {
        Queue<int> queue = new Queue<int>();
        int j = 0;
        for (int i = 0; i < cantidadCaracteres; i++) 
        {
            if (j == clave.Length) j = 0;

            queue.Enqueue(clave[j]);
            j++;
        }

        return queue;
    }

    static string Descifrar(string mensaje, int[] clave)
    {
        byte[] chars = Encoding.ASCII.GetBytes(mensaje);
        Queue<int> claves = GenerarQueueClave(clave, mensaje.Length);

        for (int i = 0; i < chars.Length; i++) 
        {
        // A-65 Z-90 a-97 z-122
            int valor = claves.Dequeue();
            int characterCode = (int)chars[i];
            
            if (characterCode < 91 && characterCode > 65 && characterCode - valor < 65) {
                chars[i] = (byte)(90 - (characterCode - valor)) ;
                
            } else if (characterCode < 123 && characterCode + valor > 122) {
                chars[i] = (byte)(122 - (characterCode - valor));
    
            } else {
                    chars[i] = (byte)(characterCode - valor);
            }
        }

        return String.Join("", Encoding.ASCII.GetString(chars));
    }
}