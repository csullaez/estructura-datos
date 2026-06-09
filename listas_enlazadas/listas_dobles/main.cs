using System;
class HelloWorld {


	// Adicionar un elemento (colegio) antes del ultimo elemento

	public static void adicionarAntesUltimo(LDobleC a) {
		NodoC w = a.getP();

		if(w == null)
			return;

		Colegio u = new Colegio();
		u.leer();

		if(w.getSig() == null)
			a.adiPrincipio(u);
		else {
			while(w.getSig() != null)
				w = w.getSig();

			NodoC nuevo = new NodoC();
			nuevo.setColegio(u);

			nuevo.setAnt(w.getAnt());
			nuevo.setSig(w);

			w.getAnt().setSig(nuevo);
			w.setAnt(nuevo);
		}
	}

	// Adicionar k elementos (colegio) despues del i-esimo elemento
	// lista [1,8,9,4], k = 4, i = 3
	// lista [1,8,9 , x1, x2, x3, x4, 4];
	// nodo 1 = x1
	// nodo 2 = x2
	// nodo 3 = x3
	// nodo 4 = x4
	// ...
	// nodo 100 = x100

	// lista [1,8], i < 2 i = 5
	public static void adicionarKElementosDespuesIesimo(LDobleC a, int i, int k) {
		if(a.nroNodos() < i) {
			Console.WriteLine("El valor de i, no puede ser superior al nro de nodos");
			return;
		}

		NodoC w = a.getP();
		int j = 0;

		while(w != null) {
			j++;
			if(j == i) {
				LDobleC b = new LDobleC();
				b.leerFinal(k);

				NodoC siguiente = w.getSig();
				b.getP().setAnt(w);

				NodoC e = b.getP();
				while(e.getSig() != null)
					e = e.getSig();

				e.setSig(siguiente);
				if(siguiente != null) {
					siguiente.setAnt(e);
				}
				w.setSig(b.getP());
				return;
			}
			w = w.getSig();
		}
	}

	static void Main() {
		LDobleC lcole = new LDobleC();

		Console.Write("Ingrese la cantidad Colegios: ");
		int n = int.Parse(Console.ReadLine());

		lcole.leerFinal(n);

		lcole.mostrar();

		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

		adicionarAntesUltimo(lcole);
		lcole.mostrar();
		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
		Console.Write("Ingrese el i-esimo elemento para adicionar k-elementos: ");
		int i = int.Parse(Console.ReadLine());

		Console.Write("Ingrese cantidad de k elementos para adicionar: ");
		int k = int.Parse(Console.ReadLine());

		adicionarKElementosDespuesIesimo(lcole, i,k);
		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
		lcole.mostrar();
	}
}
