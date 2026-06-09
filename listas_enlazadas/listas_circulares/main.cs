using System;
class HelloWorld {
	static void Main() {
		LDCircularLibro a = new LDCircularLibro();

		Console.Write("Ingrese la cantidad Libros: ");
		int n = int.Parse(Console.ReadLine());

		a.leerFinal(n);

		a.mostrar();

		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
        
        
        //nuevo: 55, lista: [23,93,45] resultado: [55, 23,93,45]
        
        // Definir metodo para eliminar el i-esimo elemento
        // Adicionar un elemento despues de cada libro creado en un año par
        /*
        l1, 2023
        l2, 2022
            leer nuevo libro e insertar
        l3, 2000
            leer nuevo libro e insertar
        l4, 2025
        
        l1, 2023
        l2, 2022
        nuevo1
        l3, 2000
        nuevo2
        l4, 2025
        */
        
        // Mostrar los libros que contienen por lo menos 3 palabras en su titulo
        
        // Don Quijote de la Mancha cantidad = 5
        // La Biblia cantidad = 2
        
        
	}
}
