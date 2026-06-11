using System;

public class Estudiante {
	private string nombre;
	private int ci, edad;

	public Estudiante() {}

	public void leer() {
		Console.Write("Ingrese el ci: ");
		ci = int.Parse(Console.ReadLine());

		Console.Write("Ingrese la nombre: ");
		nombre = Console.ReadLine();

		Console.Write("Ingrese el edad: ");
		edad = int.Parse(Console.ReadLine());
	}

	public void mostrar() {
		Console.WriteLine("[ CI: "+ci + " NOMBRE: " + nombre + " EDAD: " + edad +"]");
	}

	public int getCi() => ci;
	public string getNombre() => nombre;
	public int getEdad() => edad;

	public void setCi(int nuevoCi) {
		ci = nuevoCi;
	}

	public void setNombre(string nuevaNombre) {
		nombre = nuevaNombre;
	}

	public void setEdad(int nuevoEdad) {
		edad = nuevoEdad;
	}
}
