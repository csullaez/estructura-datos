using System;

class ColaSimpleDepto {
	private int max = 30;
	private Departamento[] v;
	private int ini;
	private int fin;

	public ColaSimpleDepto() {
		v=new Departamento[max+1];
		ini = fin = 0;
	}

	public bool esVacia() {
		return ini == 0 && fin == 0;
		//      0 == 0 && 0 == 0
		//       true   && true
		//          true
		// p AND q
		// v  V  v
		// v  F  f
		// f  F  v
		// f  F  f

	}

	public bool esLlena() {
		return fin == max;
	}

	public int nroElementos() {
		return fin - ini;
	}

	public void adicionar(Departamento nuevo) {
		if(!esLlena()) {
			fin++;
			v[fin] = nuevo;
		} else {
			Console.WriteLine("Cola Simple Departamento llena");
		}
	}

	public Departamento eliminar() {
		Departamento elemento = new Departamento();

		if(!esVacia()) {
			ini++;
			elemento = v[ini];

			if(ini == fin) {
				ini = fin = 0;
			}
		} else {
			Console.WriteLine("Cola Simple Departamento Vacia");
		}
		return elemento;
	}
	// [][][93][49]
	//   ini    fin
	public void vaciar(ColaSimpleDepto k) {
		while(!k.esVacia())
			adicionar(k.eliminar());
	}

	public void mostrar() {
		Departamento elemento;

		if(esVacia()) {
			Console.WriteLine("Cola Simple Departamento Vacia");
		} else {
			ColaSimpleDepto auxiliar = new ColaSimpleDepto();

			Console.WriteLine("DATOS DE LA COLA");

			while(!esVacia()) {
				elemento = eliminar();
				auxiliar.adicionar(elemento);
				elemento.mostrar();
			}
			vaciar(auxiliar);
		}
	}

	public void llenar(int cantidad) {
		for(int w = 1; w<=cantidad; w++) {
			Console.WriteLine("INSERTE DATOS PARA EL DEPARTAMENTO " + w);
			Departamento nuevo = new Departamento();
			nuevo.leer();
			adicionar(nuevo);
		}
	}
}
