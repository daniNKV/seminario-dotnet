/*
 Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si
es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible
por 400
*/

int x;

Console.WriteLine("Ingrese un año: ");
x = int.Parse(Console.ReadLine());

bool bisiesto;

if (x % 4 == 0 && x % 100 != 0) {
    bisiesto = true;
} else {
    if (x % 100 == 0 && x % 400 == 0) {
        bisiesto = true;
    }else {
        bisiesto = false;
    }
}

Console.WriteLine(bisiesto);