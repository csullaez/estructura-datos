using System;

public class ABBAutomovil {
	private NodoAutomovil raiz;

	public ABBAutomovil() {
		raiz = null;
	}

	public NodoAutomovil getRaiz() => raiz;
	public void setRaiz(NodoAutomovil nuevaRaiz) => raiz = nuevaRaiz;

	public void insertar(Automovil auto) {
		raiz = insertarRecursivo(raiz, auto);
	}

	public NodoAutomovil insertarRecursivo(NodoAutomovil r, Automovil automovil) {
		if( r == null ) {
			NodoAutomovil nuevo = new NodoAutomovil();
			nuevo.setAutomovil(automovil);
			return nuevo;
		}

		if(automovil.getAnio() < r.getAutomovil().getAnio()) {
			r.setIzq(insertarRecursivo(r.getIzq(), automovil));
		} else {
			r.setDer(insertarRecursivo(r.getDer(), automovil));
		}

		return r;
	}

	public void preorden(NodoAutomovil r) {
		if(r!= null) {
			r.getAutomovil().mostrar();
			preorden(r.getIzq());
			preorden(r.getDer());
		}
	}

	public void inorden(NodoAutomovil r) {
		if(r!= null) {
			inorden(r.getIzq());
			r.getAutomovil().mostrar();
			inorden(r.getDer());
		}
	}

	public void postorden(NodoAutomovil r) {
		if(r!= null) {
			postorden(r.getIzq());
			postorden(r.getDer());
			r.getAutomovil().mostrar();
		}
	}
}
