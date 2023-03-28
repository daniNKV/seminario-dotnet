// Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están
// bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena
// de entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se
// almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la extracción del
// último paréntesis de apertura almacenado. Si durante el proceso se lee un paréntesis de cierre y
// la pila está vacía, entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar
// vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida.

class Ejercicio13
{
    static void Main(string[] args) 
    {
        Console.WriteLine(VerificarBalanceoParentesis("((3 + 1) * 3"));
    }
    static bool VerificarBalanceoParentesis(string str)
    {
        bool res = true;
        List<char> parentesis = new List<char>();
        char[] chars = str.ToCharArray();
        foreach(char character in chars){
            if (String.CompareOrdinal(character.ToString(), "(") == 0) {
                parentesis.Add(character);
            } else if (String.CompareOrdinal(character.ToString(), ")") == 0) {
                if (parentesis.Count == 0) res = false;
                else parentesis.RemoveAt(0);
            }
        }

        if (parentesis.Count != 0) res = false;

        return res;
    }
}