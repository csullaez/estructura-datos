using System;

public class PilaEstudiantes {
	private int max = 30;
	private Estudiante[] v;
	private int tope;

	public PilaEstudiantes() {
		v = new Estudiante[max + 1];
		tope = 0;
	}

	public bool esVacia() => tope == 0;
	public bool esLlena() => tope == max;
	public int nroElementos() => tope;

	public void adicionar(Estudiante nuevo) {
		if(!esLlena()) {
			tope++;
			v[tope] = nuevo;
		} else
			Console.WriteLine("PILA DE ESTUDIANTES LLENA");
	}

	public Estudiante eliminar() {
		Estudiante elemento = new Estudiante();

		if(!esVacia()) {
			elemento = v[tope];
			tope--;
		} else
			Console.WriteLine("PILA DE ESTUDIANTES VACIA");
		return elemento;
	}

	public void vaciar(PilaEstudiantes d) {
		while(!d.esVacia()) {
			adicionar(d.eliminar());
		}
	}

	public void mostrar() {
		Estudiante elemento;

		if(esVacia()) {
			Console.WriteLine("PILA DE ESTUDIANTES VACIA");
			return;
		}

		Console.WriteLine("DATOS DE LA PILA DE ESTUDIANTES");
		PilaEstudiantes aux = new PilaEstudiantes();

		while(!esVacia()) {
			elemento = eliminar();
			aux.adicionar(elemento);
			elemento.mostrar();
		}
		vaciar(aux);
	}

	public void llenar(int cantidad) {
		for(int i = 1; i<=cantidad; i++) {
			Console.WriteLine("DATOS DEL ESTUDIANTE");
			Estudiante nuevo = new Estudiante();
			nuevo.leer();
			adicionar(nuevo);
		}
	}
}
