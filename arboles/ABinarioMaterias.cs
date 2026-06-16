using System;

public class ABinarioMaterias {
	private NodoMateria raiz;

	public ABinarioMaterias() {
		raiz = null;
	}

	public NodoMateria getRaiz() => raiz;
	public void setRaiz(NodoMateria nuevaRaiz) => raiz = nuevaRaiz;

	public void crear(NodoMateria r) {
		if( r != null ) {
			Console.WriteLine("INGRESE DATOS DE LA MATERIA: ");
			r.getMateria().leer();

			Console.Write(r.getMateria().getNombre() + " tendra izquierda? s/n: ");
			string respuesta = Console.ReadLine().ToUpper();

			if(respuesta == "S") {
				NodoMateria nuevo = new NodoMateria();
				r.setIzq(nuevo);
				crear(r.getIzq());
			}

			Console.Write(r.getMateria().getNombre() + " tendra derecha? s/n: ");
			respuesta = Console.ReadLine().ToUpper();

			if(respuesta == "S") {
				NodoMateria nuevo = new NodoMateria();
				r.setDer(nuevo);
				crear(r.getDer());
			}
		}
	}

	public void preorden(NodoMateria r) {
		if( r !=null ) {
			r.getMateria().mostrar();
			preorden(r.getIzq());
			preorden(r.getDer());
		}
	}

	public void inorden(NodoMateria r) {
		if( r !=null ) {
			inorden(r.getIzq());
			r.getMateria().mostrar();
			inorden(r.getDer());
		}
	}

	public void postorden(NodoMateria r) {
		if( r !=null ) {
			postorden(r.getIzq());
			postorden(r.getDer());
			r.getMateria().mostrar();
		}
	}
}
