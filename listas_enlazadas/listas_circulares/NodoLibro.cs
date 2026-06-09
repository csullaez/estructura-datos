using System;

public class NodoLibro {
	private Libro libro;
	private NodoLibro sig, ant;

	public NodoLibro() {
		sig = ant = null;
	}

	public Libro getLibro() => libro;
	public NodoLibro getSig() => sig;
	public NodoLibro getAnt() => ant;

	public void setLibro(Libro nuevoLibro) {
		libro = nuevoLibro;
	}

	public void setSig(NodoLibro nuevoSig) {
		sig = nuevoSig;
	}

	public void setAnt(NodoLibro nuevoAnt) {
		ant = nuevoAnt;
	}
}
