using System;
class HelloWorld {

	// Suponiendo que tenemos 2 colas circulares, debemos agrupar los proyectos en la primera cola
	// y los elementos se deben intercalar

	// C1 [1,3,5,7,9]
	// C2 [2,4,6,8]
	// C1 [1,2,3,4,5,6,7,8,9]

	// C1 [1,3,5,7,9]
	// C2 [2,4]
	// C1 [1,2,3,4,5,7,9]

	// C1 [1,3,5]
	// C2 [2,4,6,8,10]
	// C1 [1,2,3,4,5,6,8,10]
	
	public static void intercalarElementos2(ColaCircularProyecto a, ColaCircularProyecto b){
	    int n = a.nroElementos();
	    
	    for(int u = 1; u<=n; u++){
	        a.adicionar(a.eliminar());
	        
	        if(!b.esVacia()){
	            a.adicionar(b.eliminar());
	        }
	    }
	    
	    if(!b.esVacia()){
	        a.vaciar(b);
	    }
	    
	}
	
	public static void intercalarElementos(ColaCircularProyecto a, ColaCircularProyecto b) {
		ColaCircularProyecto aux = new ColaCircularProyecto();

		while(!a.esVacia() && !b.esVacia()) {
			Proyecto ela = a.eliminar();
			aux.adicionar(ela);

			Proyecto elb = b.eliminar();
			aux.adicionar(elb);
		}

		if(!a.esVacia()) {
			aux.vaciar(a);
		}
		if(!b.esVacia()) {
			aux.vaciar(b);
		}

		a.vaciar(aux);
	}

	public static void proyectosNotaMayorX(ColaCircularProyecto original, int x) {
		ColaCircularProyecto aux = new ColaCircularProyecto();

		while(!original.esVacia()) {
			Proyecto elemento = original.eliminar();
			aux.adicionar(elemento);

			if(elemento.getNota() > x) {
				elemento.mostrar();
			}
		}

		original.vaciar(aux);
	}

	static void Main() {
		ColaCircularProyecto a = new ColaCircularProyecto();
		ColaCircularProyecto b = new ColaCircularProyecto();

		Console.Write("Ingrese la cantidad de PROYECTOS COLA A: ");
		int n = int.Parse(Console.ReadLine());

		a.llenar(n);

		a.mostrar();

		// MOSTRAR LOS PROYECTOS CON NOTA MAYOR A X
		Console.WriteLine("***************************************************");
		// 		Console.Write("Ingrese la nota Minima de los proyectos a mostrar: ");
		// 		int x = int.Parse(Console.ReadLine());
		// 		proyectosNotaMayorX(a, x);

		Console.Write("Ingrese la cantidad de PROYECTOS COLA B: ");
		n = int.Parse(Console.ReadLine());
		b.llenar(n);

		b.mostrar();

		Console.WriteLine("***************************************************");
		intercalarElementos2(a,b);
		a.mostrar();


	}
}
