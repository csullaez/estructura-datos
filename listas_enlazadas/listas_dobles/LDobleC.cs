using System;

public class LDobleC {
	private NodoC p;

	public LDobleC() {
		p = null;
	}

	public NodoC getP() => p;

	public void setP(NodoC nuevoP) => p = nuevoP;

	public int nroNodos() {
		NodoC aux = getP();
		int contador = 0;

		while(aux != null) {
			contador++;
			aux = aux.getSig();
		}
		return contador;
	}

	public void adiPrincipio(Colegio c) {
		NodoC nuevo = new NodoC();
		nuevo.setColegio(c);

		if(getP() == null)
			setP(nuevo);
		else {
			nuevo.setSig(getP());
			getP().setAnt(nuevo);
			setP(nuevo);
		}
	}

	public void adiFinal(Colegio c) {
		NodoC nuevo = new NodoC();
		nuevo.setColegio(c);

		if(getP() == null)
			setP(nuevo);
		else {
			NodoC w = getP();

			while(w.getSig() != null)
				w = w.getSig();

			w.setSig(nuevo);
			nuevo.setAnt(w);
		}
	}

	public NodoC eliPrincipio() {
		NodoC w = getP();

		if(w == null)
			return null;
		if(w.getSig() == null)
			setP(null);//falta retorno
		else {
			setP(w.getSig());
			getP().setAnt(null);
			w.setSig(null);
		}
		return w;
	}

	public NodoC eliFinal() {
		NodoC w = getP();

		if(w == null)
			return null;
		if(w.getSig() == null)
			setP(null);//falta retorno
		else {
			while(w.getSig() != null)
				w = w.getSig();

			NodoC q = w.getAnt();
			q.setSig(null);
			w.setAnt(null);
		}

		return w;
	}

	public void leerFinal(int cantidad) {
		for(int h=0; h<cantidad; h++) {
			Console.WriteLine("INGRESE DATOS DE COLEGIO " + (h + 1));

			Colegio x = new Colegio();
			x.leer();
			adiFinal(x);
		}
	}

	public void mostrar() {
		NodoC f = getP();

		while(f!=null) {
			f.getColegio().mostrar();
			// Colegio c = f.getColegio();
			// c.mostrar();
			f= f.getSig();
		}
	}
}
