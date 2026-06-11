using System;

public class NodoCurso {
	private Curso curso;
	private LDCircularEst listaEst;
	private NodoCurso sig, ant;

	public NodoCurso() {
		sig = ant = null;
	}

	public Curso getCurso() => curso;
	public LDCircularEst getListaEst() => listaEst;
	public NodoCurso getSig() => sig;
	public NodoCurso getAnt() => ant;

	public void setCurso(Curso nuevoCurso) {
		curso = nuevoCurso;
	}

	public void setListaEst(LDCircularEst nuevListaEst) {
		listaEst = nuevListaEst;
	}
	
	public void setSig(NodoCurso nuevoSig) {
		sig = nuevoSig;
	}

	public void setAnt(NodoCurso nuevoAnt) {
		ant = nuevoAnt;
	}
}
