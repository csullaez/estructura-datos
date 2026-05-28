using System;
class HelloWorld {
    // MOSTRAR LOS ELEMENTOS PARES DE LA PILA
    public static void mostrarPares(Pila m){
        Pila auxiliar = new Pila();
        auxiliar.vaciar(m);
        
        while(!auxiliar.esVacia()){
            int elemento = auxiliar.eliminar();
            if(elemento % 2 == 0){
                Console.WriteLine(elemento + " es Par");
            }
            m.adicionar(elemento);
        }
    }
    
	static void Main() {
	    // camelCase metodoGuardar
	    // snakeCase metodo_guardar
		Pila a = new Pila();
		Console.WriteLine("La Pila esta vacia? " + a.esVacia());
		Console.WriteLine("La Pila esta llena? " + a.esLlena());
		
		a.mostrar();
		
		Console.Write("Inserte la cantidad de elementos para Pila: ");
		int cantidad = int.Parse(Console.ReadLine());
		
		a.llenar(cantidad);
		
		a.mostrar();
		
/*		Pila b = new Pila();
		Console.WriteLine("La Pila B esta vacia? " + b.esVacia());
		Console.WriteLine("EJECUTANDO VACIADO DE A -> B");
		b.vaciar(a);
		Console.WriteLine("DATOS DE LA PILA B");
		b.mostrar();
		Console.WriteLine("DATOS DE LA PILA A");
		a.mostrar();
*/		
		Console.WriteLine("MOSTRANDO ELEMENTOS PARES DE LA PILA");
		mostrarPares(a);
		
		// Crear una pila para elementos de tipo STRING, CHAR, BOOL

	}
}
