using System;

class LSimpleString {
	private NodoString p; // cabeza, puntero o p

	public LSimpleString() {
		p = null;
	}

	public NodoString getP() => p;

	public void setP(NodoString nuevoP) {
		p = nuevoP;
	}

	public int nroNodos() {
		NodoString w = getP();
		int contador = 0;

		while(w!=null) {
			contador++;
			w = w.getSig();
		}
		return contador;
	}

	public void adicionarPrincipio(string dato) {
		NodoString nuevo = new NodoString();
		nuevo.setNombre(dato);

		nuevo.setSig(getP());
		setP(nuevo);
	}

	public void adicionarFinal(string dato) {
		NodoString nuevo = new NodoString();
		nuevo.setNombre(dato);

		if(getP() == null) { // if(nroNodos == 0)
			setP(nuevo);
		} else {
			NodoString w = getP();
			while(w.getSig() != null) {
				w = w.getSig();
			}
			w.setSig(nuevo);
		}
	}

	public NodoString eliminarPrincipio() {
		NodoString r = getP();

		if(r!=null) {
			setP(r.getSig());
			r.setSig(null);
		}
		return r;
	}

	// TAREA: CREAR ELIMINAR POR EL FINAL

	public void leerFinal(int cantidad) {
		for(int i = 0; i<cantidad; i++) {
			Console.Write("Ingrese el nombre del estudiante: ");
			string dato = Console.ReadLine();

			adicionarFinal(dato);
		}
	}

	public void leerPrincipio(int cantidad) {
		for(int s = 0; s< cantidad; s++) {
			Console.Write("Ingrese el nombre del estudiante: ");
			string dato = Console.ReadLine();

			adicionarPrincipio(dato);
		}
	}

	public void mostrar() {
		NodoString w = getP();

		while(w!=null) {
			Console.WriteLine(w.getNombre());
			w = w.getSig();
		}
	}
}
