using System;

public class LDCircularLibro {
	private NodoLibro p;

	public LDCircularLibro() {
		p = null;
	}

	public NodoLibro getP() => p;

	public void setP(NodoLibro nuevoP) => p = nuevoP;

	public int nroNodos() {
		
		if(getP() == null)
		    return 0;
		
		NodoLibro aux = getP();
		int contador = 1;

		//while(aux != null) { [8,3,4]
		while(aux.getSig() != getP()) {
			contador++;
			aux = aux.getSig();
		}
		
		return contador;
	}

	public void adiPrincipio(Libro c) {
		NodoLibro nuevo = new NodoLibro();
		nuevo.setLibro(c);

		if(getP() == null){ // [] 12
			setP(nuevo);
			nuevo.setSig(nuevo);
			nuevo.setAnt(nuevo);
		}
		else {
		    //nuevo: 55, lista: [23,93,45] resultado: [55, 23,93,45]
		    NodoLibro w = getP();
		    while(w.getSig() != getP())
		        w = w.getSig();
		        
		    w.setSig(nuevo);
		    nuevo.setAnt(w);
		    
		    nuevo.setSig(getP());
		    getP().setAnt(nuevo);
		    
		    setP(nuevo);
		}
	}

	public void adiFinal(Libro c) {
		NodoLibro nuevo = new NodoLibro();
		nuevo.setLibro(c);

		if(getP() == null){ // [] 12
			setP(nuevo);
			nuevo.setSig(nuevo);
			nuevo.setAnt(nuevo);
		}
		else {
		    //nuevo: 55, lista: [23,93,45] resultado: [23,93,45, 55]
			NodoLibro w = getP();

			while(w.getSig() != getP())
				w = w.getSig();
            
            w.setSig(nuevo);
            nuevo.setAnt(w);
            
            nuevo.setSig(getP());
            getP().setAnt(nuevo);
		}
	}

	public NodoLibro eliPrincipio() {
		NodoLibro w = getP();

		if(w == null)
			return null;
		if(getP().getSig() == getP()){
			setP(null);
			w.setSig(null);
			w.setAnt(null);
		}
		else {
		    NodoLibro r = getP();
		    while(r.getSig() != getP())
		        r=r.getSig();
		        
		    //lista: [23,93,45] resultado: [93,45]
		    setP(getP().getSig());
		    
		    r.setSig(getP());
		    getP().setAnt(r);
		    
		    w.setSig(null);
		    w.setAnt(null);
		}
		return w;
	}

	public NodoLibro eliFinal() {
		NodoLibro w = getP();

		if(w == null)
			return null;
		if(getP().getSig() == getP()){
			setP(null);
			w.setSig(null);
			w.setAnt(null);
		}
		else {
		    //lista: [23,93,45] resultado: [23,93]
			NodoLibro r = getP();
			while(r.getSig() != getP())
			    r = r.getSig();
			
			NodoLibro q = r.getAnt();
			q.setSig(getP());
			getP().setAnt(q);
			
			r.setSig(null);
			r.setAnt(null);
			
			w = r;
		}

		return w;
	}

	public void leerFinal(int cantidad) {
		for(int h=0; h<cantidad; h++) {
			Console.WriteLine("INGRESE DATOS DE Libro " + (h + 1));

			Libro x = new Libro();
			x.leer();
			adiFinal(x);
		}
	}

	public void mostrar() {
	    
	    if(getP() == null){
	        Console.WriteLine("Lista VACIA");
	        return;
	    }
	    
		NodoLibro f = getP();
        //lista: [23,93,45]
		while(f.getSig()!=getP()) {
			f.getLibro().mostrar();
			f= f.getSig();
		}
		f.getLibro().mostrar();
	}
}
