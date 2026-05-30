using System;

class PilaEstudiantes {
	private int max = 30;
	private Estudiante[] v;
	private int tope;

	public PilaEstudiantes() {
		v = new Estudiante[max + 1];
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

	public void adicionar(Estudiante nuevo) {
		if(!esLlena()) {
			tope++;
			v[tope] = nuevo;
		} else {
			Console.WriteLine("Pila Estudiantes llena");
		}
	}

	public Estudiante eliminar() {
		Estudiante elemento = new Estudiante(); // Usa constructor por defecto

		if(!esVacia()) {
			elemento = v[tope];
			tope--;
		} else {
			Console.WriteLine("Pila Estudiantes vacia");
		}
		return elemento;
	}

	public void vaciar(PilaEstudiantes k) {
		while(!k.esVacia()) {
			adicionar(k.eliminar());
		}
	}

	public void mostrar() {
		Estudiante elemento;

		if(esVacia()) {
			Console.WriteLine("Pila Estudiantes Vacia - No hay nada que mostrar");
		} else {
			Console.WriteLine("DATOS PILA ESTUDIANTES");
			PilaEstudiantes auxiliar = new PilaEstudiantes();

			while(!esVacia()) {
				elemento = eliminar(); // eliminar() -> Eliminar y retorna el dato
				auxiliar.adicionar(elemento);
				elemento.mostrar(); // Console.WriteLine(elemento);
			}
			vaciar(auxiliar);
		}
	}

	public void llenar(int cantidad) {
		for(int s=1; s<=cantidad; s++) {
			Estudiante nuevo = new Estudiante();
			Console.WriteLine("INGRESE LOS DATOS DEL ESTUDIANTE " + s +": ");
			nuevo.leer();
			adicionar(nuevo);
		}
	}
}
