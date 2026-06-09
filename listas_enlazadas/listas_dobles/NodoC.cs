using System;

public class NodoC{
    private Colegio colegio;
    private NodoC sig, ant;
    
    public NodoC(){
        sig = ant = null;
    }
    
    public Colegio getColegio() => colegio;
    public NodoC getSig() => sig;
    public NodoC getAnt() => ant;
    
    public void setColegio(Colegio nuevoColegio) {
        colegio = nuevoColegio;
    }
    
    public void setSig(NodoC nuevoSig){
        sig = nuevoSig;
    }
    
    public void setAnt(NodoC nuevoAnt){
        ant = nuevoAnt;
    }
}
