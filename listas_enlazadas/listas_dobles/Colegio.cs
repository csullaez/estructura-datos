using System;

public class Colegio {
	private string nombre, direccion, turno;
	private int nroEstudiantes;

	public Colegio() {}

	public void leer() {
		Console.Write("Ingrese el nombre:");
		nombre = Console.ReadLine();

		Console.Write("Ingrese la direccion:");
		direccion = Console.ReadLine();

		Console.Write("Ingrese el turno:");
		turno = Console.ReadLine();

		Console.Write("Ingrese el nro de estudiantes:");
		nroEstudiantes = int.Parse(Console.ReadLine());
	}

	public void mostrar() {
		Console.WriteLine("[ NOMBRE: "+ nombre + " DIRECCION: "+ direccion + " TURNO: " + turno + " ESTUDIANTES: " + nroEstudiantes + " ]");
	}
	
	public string getNombre() => nombre;
	public string getDireccion() => direccion;
	public string getTurno() => turno;
	public int getNroEstudiantes() => nroEstudiantes;
	
	public void setNombre(string nuevoNombre) {
	    nombre = nuevoNombre;
	}
	
	public void setDireccion(string nuevaDireccion) {
	    direccion = nuevaDireccion;
	}
	
	public void setTurno(string nuevoTurno) {
	    turno = nuevoTurno;
	}
	
	public void setNroEstudiantes(int nuevoNroEstudiantes) {
	    nroEstudiantes = nuevoNroEstudiantes;
	}

}
