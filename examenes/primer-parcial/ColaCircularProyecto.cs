using System;

class ColaCircularProyecto {
    private int max = 50;
    private Proyecto[] v;
    private int ini, fin;
    
    public ColaCircularProyecto() {
        v = new Proyecto[max + 1];
        ini = fin = 0;
    }
    
    public int nroElementos(){
        return (max + fin - ini) % max;
    }
    
    public bool esVacia(){
        return nroElementos() == 0;
    }
    
    public bool esLlena(){
        return nroElementos() == max - 1;
    }
    
    public void adicionar(Proyecto nuevo){
        if(esLlena()){
            Console.WriteLine("COLA CIRCULAR PROYECTOS LLENA");
        } else {
            fin = (fin + 1) % max;
            v[fin] = nuevo;
        }
    }
    
    public Proyecto eliminar(){
        Proyecto elemento = new Proyecto();
        
        if(!esVacia()){
            ini = (ini + 1) % max;
            elemento = v[ini];
            
            if(nroElementos() == 0){
                ini = fin = 0;
            }
        } else {
            Console.WriteLine("COLA CIRCULAR VACIA");
        }
        
        return elemento;
    }
    
    public void vaciar(ColaCircularProyecto h){
        while(!h.esVacia()){
            adicionar(h.eliminar());
        }
    }
    
    public void mostrar(){
        Proyecto elemento;
        
        if(esVacia()){
            Console.WriteLine("NO HAY NADA QUE MOSTRAR");
        } else {
            Console.WriteLine("ELEMENTOS DE LA COLA CIRCULAR");
            
            ColaCircularProyecto aux = new ColaCircularProyecto();
            
            while(!esVacia()){
                elemento = eliminar();
                aux.adicionar(elemento);
                elemento.mostrar();
            }
            
            vaciar(aux);
        }
    }
    
    public void llenar(int cantidad){
        for(int y = 1; y<=cantidad; y++){
            Console.WriteLine("INGRESE DATOS DEL PROYECTO "+ y);
            Proyecto elemento = new Proyecto();
            elemento.leer();
            adicionar(elemento);
        }
    }
}
