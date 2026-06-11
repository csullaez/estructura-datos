using System;

public class LDobleCurso{
    private NodoCurso p;
    
    public LDobleCurso(){
        p = null;
    }
    
    public NodoCurso getP() => p;
    
    public void setP(NodoCurso nuevoP) => p = nuevoP;
    
    public int nroNodos(){
        NodoCurso aux = getP();
        int contador = 0;
        
        while(aux != null){
            contador++;
            aux = aux.getSig();
        }
        return contador;
    }
    
    public void adiPrincipio(Curso c, LDCircularEst lest){
        NodoCurso nuevo = new NodoCurso();
        nuevo.setCurso(c);
        nuevo.setListaEst(lest);
        
        if(getP() == null)
            setP(nuevo);
        else {
            nuevo.setSig(getP());
            getP().setAnt(nuevo);
            setP(nuevo);
        }
    }
    
    public void adiFinal(Curso c, LDCircularEst lest){
        NodoCurso nuevo = new NodoCurso();
        nuevo.setCurso(c);
        nuevo.setListaEst(lest);
        
        if(getP() == null)
            setP(nuevo);
        else {
            NodoCurso w = getP();
            while(w.getSig() != null)
                w = w.getSig();
                
            w.setSig(nuevo);
            nuevo.setAnt(w);
        }
    }
    
    public NodoCurso eliPrincipio(){
        NodoCurso w = getP();
        
        if(w == null)
            return null;
        if(w.getSig() == null)
            setP(null);
        else {
            setP(w.getSig());
            getP().setAnt(null);
            w.setSig(null);
        }
        return w;
    }
    
    public NodoCurso eliFinal(){
        NodoCurso w = getP();
        
        if(w == null)
            return null;
        if(w.getSig() == null)
            setP(null);
        else {
            while(w.getSig() !=null)
                w = w.getSig();
            
            NodoCurso q = w.getAnt();
            q.setSig(null);
            w.setAnt(null);
        }   
        return w;
    }
    
    public void leerFinal(int cantidad){
        for(int i = 1; i<= cantidad; i++){
            Console.WriteLine("INGRESE LOS DATOS DEL CURSO " + i);
            
            Curso c = new Curso();
            c.leer();
            
            Console.Write("INGRESE LA CANTIDAD DE ESTUDIANTES: ");
            LDCircularEst lest = new LDCircularEst();
            int n = int.Parse(Console.ReadLine());
            lest.leerFinal(n);
            
            adiFinal(c, lest);
        }
    }
    
    public void mostrar(){
        NodoCurso q = getP();
        
        while(q!=null){
            q.getCurso().mostrar();
            q.getListaEst().mostrar();
            q = q.getSig();
        }
    }
}
