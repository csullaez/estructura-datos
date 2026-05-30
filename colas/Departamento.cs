using System;

class Departamento {
	private int idDepto;
	private string nombre;
	private string capital;
	private double superficie;
	private int poblacion;

	public Departamento() {}

	public void leer() {
		Console.Write("Inserte Id Departamento: ");
		idDepto = int.Parse(Console.ReadLine());

		Console.Write("Inserte el nombre: ");
		nombre = Console.ReadLine();

		Console.Write("Inserte la Capital: ");
		capital = Console.ReadLine();

		Console.Write("Inserte la superficie: ");
		superficie = double.Parse(Console.ReadLine());

		Console.Write("Inserte poblacion: ");
		poblacion = int.Parse(Console.ReadLine());
	}

	public void mostrar() {
		Console.WriteLine("[ IDDEPTO:" + idDepto + " NOMBRE: "+ nombre);
		Console.WriteLine(" CAPITAL:" + capital + " SUPERFICIE: "+ superficie + " POBLACION: " + poblacion + "]");
	}

	public int getIdDepto() => idDepto;
	public string getNombre() => nombre;
	public string getCapital() => capital;
	public double getSuperficie() => superficie;
	public int getPoblacion() => poblacion;

	public void setIdDepto(int nuevoIdDepto) {
		idDepto = nuevoIdDepto;
	}
	public void setNombre(string nuevoNombre) {
		nombre = nuevoNombre;
	}
	public void setCapital(string nuevaCapital) {
		capital = nuevaCapital;
	}
	public void setSuperficie(double nuevaSuperficie) {
		superficie = nuevaSuperficie;
	}
	public void setPoblacion(int nuevaPoblacion) {
		poblacion = nuevaPoblacion;
	}
}
