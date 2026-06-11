using System;

public class NodoEst {
	private Estudiante estudiante;
	private NodoEst sig, ant;

	public NodoEst() {
		sig = ant = null;
	}

	public Estudiante getEstudiante() => estudiante;
	public NodoEst getSig() => sig;
	public NodoEst getAnt() => ant;

	public void setEstudiante(Estudiante nuevoEstudiante) {
		estudiante = nuevoEstudiante;
	}

	public void setSig(NodoEst nuevoSig) {
		sig = nuevoSig;
	}

	public void setAnt(NodoEst nuevoAnt) {
		ant = nuevoAnt;
	}
}
