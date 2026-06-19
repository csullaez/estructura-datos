using System;

public class Ciudad {
    private int codigo, poblacion;
    private string nombre, departamento;
    
    public Ciudad() {} // Constructor por defecto
    
    // Constructor con parametros
    public Ciudad(int codigo, string nombre, string departamento, int poblacion) {
        this.codigo = codigo;
        this.nombre = nombre;
        this.departamento = departamento;
        this.poblacion = poblacion;
    }
    
    public void leer() {
        Console.Write("Ingrese el codigo: ");
        codigo = int.Parse(Console.ReadLine());
        
        Console.Write("Ingrese el nombre: ");
        nombre = Console.ReadLine();
        
        Console.Write("Ingrese el departamento: ");
        departamento = Console.ReadLine();
        
        Console.Write("Ingrese la poblacion: ");
        poblacion = int.Parse(Console.ReadLine());
    }
    
    public void mostrar() {
        Console.WriteLine("[ CODIGO: " + codigo + " NOMBRE: " + nombre + " DEPARTAMENTO: " + departamento + " POBLACION: " + poblacion);
    }
    
    public int getCodigo() => codigo;
    public string getNombre() => nombre;
    public string getDepartamento() => departamento;
    public int getPoblacion() => poblacion;
    
    public void setCodigo(int nuevoCodigo) => codigo = nuevoCodigo;
    public void setNombre(string nuevoNombre) => nombre = nuevoNombre;
    public void setDepartamento(string nuevoDepartamento) => departamento = nuevoDepartamento;
    public void setPoblacion(int nuevaPoblacion) => poblacion = nuevaPoblacion;
}
