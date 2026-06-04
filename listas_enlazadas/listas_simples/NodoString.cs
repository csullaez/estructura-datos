using System;

public class NodoString {
	private string nombre;
	private NodoString sig;

	public NodoString() {
		sig = null;
	}

	public string getNombre() => nombre;

	public NodoString getSig() => sig;

	public void setNombre(string nuevoNombre) {
		nombre = nuevoNombre;
	}

	public void setSig(NodoString nuevoSig) {
		sig = nuevoSig;
	}
}
