using System;

public class Estudiante {
    private int ci, matricula, edad;
    private string nombre;
    
    public Estudiante() {}
    
    public void leer(){
        Console.Write("Ingrese el CI: ");
        ci = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();
        
        Console.Write("Ingrese la matricula: ");
        matricula = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine());
    }
    
    public void mostrar() {
        Console.WriteLine("[ CI: " +ci + " NOMBRE: " + nombre + " MATRICULA: " + matricula + " EDAD: " + edad + "]");
    }
    
    public int getCi() => ci;
    public string getNombre() => nombre;
    public int getMatricula() => matricula;
    public int getEdad() => edad;
    
    public void setCi(int nuevoCI) => ci = nuevoCI;
    public void setNombre(string nuevoNombre) => nombre = nuevoNombre;
    public void setMatricula(int nuevaMatricula) => matricula = nuevaMatricula;
    public void setEdad(int nuevaEdad) => edad = nuevaEdad;
}
