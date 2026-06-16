using System;

public class Materia {
    private string nombre, codigo, docente;
    private int semestre;
    private PilaEstudiantes pilaEstudiantes;
    
    public Materia(){
        pilaEstudiantes = new PilaEstudiantes();
    }
    
    public void leer() {
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();
        
        Console.Write("Ingrese el codigo: ");
        codigo = Console.ReadLine();
        
        Console.Write("Ingrese el docente: ");
        docente = Console.ReadLine();
        
        Console.Write("Ingrese el semestre: ");
        semestre = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese la cantidad de estudiantes: ");
        int n = int.Parse(Console.ReadLine());
        
        pilaEstudiantes.llenar(n);
    }
    
    public void mostrar(){
        Console.WriteLine("============================================================================");
        Console.WriteLine("[ MATERIA: " + nombre + " CODIGO: " + codigo + " DOCENTE: " + docente + " SEM: " + semestre + "]");
        pilaEstudiantes.mostrar();
        Console.WriteLine("============================================================================");
    }
    
    public string getNombre() => nombre;
    public string getCodigo() => codigo;
    public string getDocente() => docente;
    public int getSemestre() => semestre;
    public PilaEstudiantes getPilaEstudiantes() => pilaEstudiantes;

    public void setNombre(string nuevoNombre) => nombre = nuevoNombre;
    public void setCodigo(string nuevoCodigo) => codigo = nuevoCodigo;
    public void setDocente(string nuevoDocente) => docente = nuevoDocente;
    public void setSemestre(int nuevoSemestre) => semestre = nuevoSemestre;
    public void setPilaEstudiantes(PilaEstudiantes nuevaPila) => pilaEstudiantes = nuevaPila;
}
