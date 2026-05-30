using System;

class PilaEvaluaciones {
	private int max = 30;
	private Evaluacion[] v;
	private int tope;

	public PilaEvaluaciones() {
		v = new Evaluacion[max + 1];
		tope = 0;
	}

	public bool esVacia() {
		return tope == 0;
	}

	public bool esLlena() {
		return tope == max;
	}

	public int nroElementos() {
		return tope;
	}

	public void adicionar(Evaluacion nuevo) {
		if(!esLlena()) {
			tope++;
			v[tope] = nuevo;
		} else {
			Console.WriteLine("Pila Evaluaciones llena");
		}
	}

	public Evaluacion eliminar() {
		Evaluacion elemento = new Evaluacion(); // Usa constructor por defecto

		if(!esVacia()) {
			elemento = v[tope];
			tope--;
		} else {
			Console.WriteLine("Pila Estudiantes vacia");
		}
		return elemento;
	}

	public void vaciar(PilaEvaluaciones k) {
		while(!k.esVacia()) {
			adicionar(k.eliminar());
		}
	}

	public void mostrar() {
		Evaluacion elemento;

		if(esVacia()) {
			Console.WriteLine("Pila Evaluaciones Vacia - No hay nada que mostrar");
		} else {
			Console.WriteLine("DATOS PILA EVALUACIONES");
			PilaEvaluaciones auxiliar = new PilaEvaluaciones();

			while(!esVacia()) {
				elemento = eliminar(); // eliminar() -> Eliminar y retorna el dato
				auxiliar.adicionar(elemento);
				elemento.mostrar();
			}
			vaciar(auxiliar);
		}
	}

	public void llenar(int cantidad) {
		for(int s=1; s<=cantidad; s++) {
			Evaluacion nuevo = new Evaluacion();
			Console.WriteLine("INGRESE LOS DATOS DE LA EVALUACION " + s +": ");
			nuevo.leer();
			adicionar(nuevo);
		}
	}
}
