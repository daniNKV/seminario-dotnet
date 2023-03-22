Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?
` ` ` 
char c;
char? c2;
string? st;
c = "";
c = '';
c = null; // ERROR, c no es nullable type
c2 = null;
c2 = (65 as char?); // 65 as char? genera nulo pero no error
st = "";
st = '';
st = null;
st = (char)65; // ERROR, 65 no puede ser casteado a un char, posee dos digitos.
st = (string)65;
st = 47.89.ToString();
` ` ` 

