using System;

class PilaColasProyecto {
	private int max = 50;
	private ColaCircularProyecto[] v;
	private int tope;

	public PilaColasProyecto() {
		v = new ColaCircularProyecto[max + 1];
		tope = 0;
	}

	public bool esVacia() {
		return tope == 0;
	}

	public bool esLlena() {
		return tope == max;
	}

	public void adicionar(ColaCircularProyecto nuevo) {
		if(!esLlena()) {
			tope++;
			v[tope] = nuevo;
		} else {
			Console.WriteLine("PILA DE COLAS LLENA");
		}
	}

	public ColaCircularProyecto eliminar() {
		ColaCircularProyecto elemento = new ColaCircularProyecto();

		if(!esVacia()) {
			elemento = v[tope];
			tope--;
		} else {
			Console.WriteLine("PILA DE COLAS VACIA");
		}
		return elemento;
	}

	public void vaciar(PilaColasProyecto y) {
		while(!y.esVacia()) {
			adicionar(y.eliminar());
		}
	}

	public void mostrar() {
		PilaColasProyecto aux = new PilaColasProyecto();
        Console.WriteLine("DATOS DE LA PILA DE COLAS");
		while(!esVacia()) {
			ColaCircularProyecto cola = eliminar();
			aux.adicionar(cola);
            
			cola.mostrar();
		}
		vaciar(aux);
	}

	public void llenar(int cantidad) {
		for(int g = 1; g<= cantidad; g++) {
			ColaCircularProyecto y = new ColaCircularProyecto();

			Console.Write("Ingrese la cantidad de Proyectos en la COLA: ");
			int n = int.Parse(Console.ReadLine());

			y.llenar(n);
			
			adicionar(y);
		}
	}
}
