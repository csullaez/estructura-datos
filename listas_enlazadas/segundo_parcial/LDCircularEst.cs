using System;

public class LDCircularEst{
    private NodoEst p;
    
    public LDCircularEst(){
        p = null;
    }
    
    public NodoEst getP() => p;
    
    public void setP(NodoEst nuevoP) => p = nuevoP;
    
    public int nroNodos(){
        if(getP() == null)
            return 0;
        // [2,8,3]
        NodoEst aux = getP();
        int contador = 1;
        
        while(aux.getSig() != getP()){
            contador++;
            aux = aux.getSig();
        }
        return contador;
    }
    
    public void adiPrincipio(Estudiante c){
        NodoEst nuevo = new NodoEst();
        nuevo.setEstudiante(c);
        
        if(getP() == null){ //[]
            setP(nuevo);
            nuevo.setSig(nuevo);
            nuevo.setAnt(nuevo);
        }
        else { // [2,3,8] -> [nuevo, 2,3,8]
            NodoEst w = getP();
            while(w.getSig()!=getP())
                w = w.getSig();
                
            w.setSig(nuevo);
            nuevo.setAnt(w);
            
            nuevo.setSig(getP());
            getP().setAnt(nuevo);
            
            setP(nuevo);
        }
    }
    
    public void adiFinal(Estudiante c){
        NodoEst nuevo = new NodoEst();
        nuevo.setEstudiante(c);
        
        if(getP() == null){ //[]
            setP(nuevo);
            nuevo.setSig(nuevo);
            nuevo.setAnt(nuevo);
        }
        else {// [2,3,8] -> [2,3,8, nuevo]
            NodoEst w = getP();
            while(w.getSig() != getP())
                w = w.getSig();
                
            w.setSig(nuevo);
            nuevo.setAnt(w);
            
            nuevo.setSig(getP());
            getP().setAnt(nuevo);
        }
    }
    
    public NodoEst eliPrincipio(){
        NodoEst w = getP();
        
        if(w == null)
            return null;
        if(w.getSig() == getP()){ // [2]
            setP(null);
            w.setSig(null);
            w.setAnt(null);
        }// [2,3,8] 
        else {
            NodoEst r = getP();
            while(r.getSig() != getP())
                r = r.getSig();
            
            setP(getP().getSig());
            
            r.setSig(getP());
            getP().setAnt(r);
            
            w.setSig(null);
            w.setAnt(null);
        }
        return w;
    }
    
    public NodoEst eliFinal(){
        NodoEst w = getP();
        
        if(w == null) // [] return null
            return null;
        // if(getP().getSig() == getP())
        if(w.getSig() == getP()){ // [2] return 2 y []
            setP(null);
            w.setSig(null);
            w.setAnt(null);
        }
        else {// [2,3,8] -> [2,3] 
            NodoEst r = getP();
            while(r.getSig()!=getP())
                r = r.getSig();
            
            NodoEst q = r.getAnt();
            q.setSig(getP());
            getP().setAnt(q);
            
            r.setSig(null);
            r.setAnt(null);
            
            w = r;
        }   
        return w;
    }
    
    public void leerFinal(int cantidad){
        for(int i = 1; i<= cantidad; i++){
            Console.WriteLine("INGRESE LOS DATOS DEL ESTUDIANTE " + i);
            
            Estudiante c = new Estudiante();
            c.leer();
            
            adiFinal(c);
        }
    }
    
    public void mostrar(){
        if(getP() == null){
            Console.WriteLine("Lista Vacia");
            return;
        }
        
        NodoEst q = getP();
        // / [2,3,8]
        while(q.getSig()!=getP()){
            q.getEstudiante().mostrar();
            q = q.getSig();
        }
        q.getEstudiante().mostrar();
    }
}
