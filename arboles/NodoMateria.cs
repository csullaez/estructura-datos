using System;

public class NodoMateria {
    private Materia materia;
    private NodoMateria izq, der;
    
    public NodoMateria(){
        izq = der = null;
        materia = new Materia();
    }
    
    public Materia getMateria() => materia;
    public NodoMateria getIzq() => izq;
    public NodoMateria getDer() => der;
    
    public void setMateria(Materia nuevaMateria) => materia = nuevaMateria;
    public void setIzq(NodoMateria nuevaIzq) => izq = nuevaIzq;
    public void setDer(NodoMateria nuevaDer) => der = nuevaDer;
}
