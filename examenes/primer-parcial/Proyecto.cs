using System;

class Proyecto {
    private string titulo;
    private int nota;
    private string nombreEstudiante;
    private string area;
    private int gestion;
    private string estado;
    
    public Proyecto(){}
    
    public void leer(){
        Console.Write("Ingrese el titulo: ");
        titulo = Console.ReadLine();
        
        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el Nombre del Estudiante: ");
        nombreEstudiante = Console.ReadLine();
        
        Console.Write("Ingrese area: ");
        area = Console.ReadLine();
        
        Console.Write("Ingrese gestion: ");
        gestion = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese estado (Aprobado, Reprobado, Pendiente): ");
        estado = Console.ReadLine();
    }
    
    public void mostrar(){
        Console.WriteLine("[ TITULO: "+ titulo + " NOTA: "+ nota + " ESTUDIANTE: "+ nombreEstudiante);
        Console.WriteLine(" AREA: "+ area + " GESTION: "+ gestion + " ESTADO: "+ estado +"]");
    }
    
    public string getTitulo() => titulo;
    public int getNota() => nota;
    public string getNombreEstudiante() => nombreEstudiante;
    public string getArea() => area;
    public int getGestion() => gestion;
    public string getEstado() => estado;
    
    public void setTitulo(string nuevoTitulo){
        titulo = nuevoTitulo;
    }
    
    public void setNota(int nuevaNota){
        nota = nuevaNota;
    }
    
    public void setNombreEstudiante(string nuevoNombreEstudiante){
        nombreEstudiante = nuevoNombreEstudiante;
    }
    
    public void setArea(string nuevaArea){
        area = nuevaArea;
    }
    
    public void setGestion(int nuevaGestion){
        gestion = nuevaGestion;
    }
    
    public void setEstado(string nuevoEstado){
        estado = nuevoEstado;
    }
}
