using System;

public class NodoAutomovil {
    private Automovil automovil;
    private NodoAutomovil izq, der;
    
    public NodoAutomovil(){
        automovil = new Automovil();
        izq = der = null;
    }
    
    public Automovil getAutomovil() => automovil;
    public NodoAutomovil getIzq() => izq;
    public NodoAutomovil getDer() => der;
    
    public void setAutomovil(Automovil nuevoAuto) => automovil = nuevoAuto;
    public void setIzq(NodoAutomovil nuevaIzq) => izq = nuevaIzq;
    public void setDer(NodoAutomovil nuevaDer) => der = nuevaDer;
}
