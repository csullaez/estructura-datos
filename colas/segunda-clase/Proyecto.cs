using System;

class Proyecto {
    private string titulo;
    private int nota;
    private string nombreEstudiante;
    
    public Proyecto(){}
    
    public void leer(){
        Console.Write("Ingrese el titulo: ");
        titulo = Console.ReadLine();
        
        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el Nombre del Estudiante: ");
        nombreEstudiante = Console.ReadLine();
    }
    
    public void mostrar(){
        Console.WriteLine("[ TITULO: "+ titulo + " NOTA: "+ nota + " ESTUDIANTE: "+ nombreEstudiante +"]");
    }
    
    public string getTitulo() => titulo;
    public int getNota() => nota;
    public string getNombreEstudiante() => nombreEstudiante;
    
    public void setTitulo(string nuevoTitulo){
        titulo = nuevoTitulo;
    }
    
    public void setNota(int nuevaNota){
        nota = nuevaNota;
    }
    
    public void setNombreEstudiante(string nuevoNombreEstudiante){
        nombreEstudiante = nuevoNombreEstudiante;
    }
}
