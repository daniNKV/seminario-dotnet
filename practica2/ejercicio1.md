Qué líneas del siguiente código provocan conversiones boxing y unboxing.

Boxing: Se convierten tipos de valor como valores primitivos en tipos object o sus implementaciones de interfaz. Pasando de guardarse su valor en el stack a que el valor sea la referencia de donde esta almacenado en la memoria heap.

Unboxing: La conversión es realizada desde un tipo object o hijo de este. El valor almacenado en la memoria heap es casteado para almacenarse directamente en el stack. 

 ` ` `
    char c1 = 'A'; 
    string st1 = "A"; // Conversión  
    object o1 = c1; // Conversión boxing
    object o2 = st1; // Conversión boxing
    char c2 = (char)o1; // Conversión unboxing
    string st2 = (string)o2; // Conversión unboxing

 ` ` `

 