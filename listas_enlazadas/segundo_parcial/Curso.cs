using System;

public class Curso {
	private string sigla, nombre;
	private int semestre;

	public Curso() {}

	public void leer() {
		Console.Write("Ingrese el sigla: ");
		sigla = Console.ReadLine();

		Console.Write("Ingrese la nombre: ");
		nombre = Console.ReadLine();

		Console.Write("Ingrese el semestre: ");
		semestre = int.Parse(Console.ReadLine());
	}

	public void mostrar() {
		Console.WriteLine("[ SIGLA: "+sigla + " NOMBRE: " + nombre + " SEMESTRE: " + semestre +"]");
	}

	public string getSigla() => sigla;
	public string getNombre() => nombre;
	public int getSemestre() => semestre;

	public void setSigla(string nuevaSigla) {
		sigla = nuevaSigla;
	}

	public void setNombre(string nuevoNombre) {
		nombre = nuevoNombre;
	}

	public void setSemestre(int nuevoSemestre) {
		semestre = nuevoSemestre;
	}
}
