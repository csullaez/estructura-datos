using System;

public class Libro {
	private string codigo, autor, titulo;
	private int anio;

	public Libro() {}

	public void leer() {
		Console.Write("Ingrese el codigo:");
		codigo = Console.ReadLine();

		Console.Write("Ingrese la autor:");
		autor = Console.ReadLine();

		Console.Write("Ingrese el titulo:");
		titulo = Console.ReadLine();

		Console.Write("Ingrese el anio:");
		anio = int.Parse(Console.ReadLine());
	}

	public void mostrar() {
		Console.WriteLine("[ CODIGO: "+ codigo + " AUTOR: "+ autor + " TITULO: " + titulo + " ANIO: " + anio + " ]");
	}
	
	public string getCodigo() => codigo;
	public string getAutor() => autor;
	public string getTitulo() => titulo;
	public int getAnio() => anio;
	
	public void setCodigo(string nuevoCodigo) {
	    codigo = nuevoCodigo;
	}
	
	public void setAutor(string nuevoAutor) {
	    autor = nuevoAutor;
	}
	
	public void setTitulo(string nuevoTitulo) {
	    titulo = nuevoTitulo;
	}
	
	public void setAnio(int nuevoAnio) {
	    anio = nuevoAnio;
	}
}
