using System;

class Pila {
	private int max = 30;
	private int[] v;
	private int tope;

	public Pila() {
		v = new int[max + 1];
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

	public void adicionar(int nuevo) {
		if(!esLlena()) {
			tope++;
			v[tope] = nuevo;
		} else {
			Console.WriteLine("Pila llena");
		}
	}

	public int eliminar() {
		int elemento = 0;
		if(!esVacia()) {
			elemento = v[tope];
			tope--;
		} else {
			Console.WriteLine("Pila Vacia - No hay elementos");
		}
		return elemento;
	}

	public void vaciar(Pila w) {
		while(!w.esVacia()) {
			adicionar(w.eliminar()); //push(w.pop())
		}
	}

	public void mostrar() {
		int elemento;

		if(esVacia()) {
			Console.WriteLine("Pila vacia - No hay nada que mostrar");
		} else {
			Console.WriteLine("Datos de la Pila");
			Pila aux = new Pila();

			while(!esVacia()) {
				elemento = eliminar();
				aux.adicionar(elemento);
				Console.WriteLine(elemento);
			}
			vaciar(aux);
		}
	}

	public void llenar(int n) {
		for(int q = 1; q<=n; q++) {
			Console.Write("Inserte el valor " + q + " : ");
			int nuevo = int.Parse(Console.ReadLine());
			adicionar(nuevo);
		}
	}
}
