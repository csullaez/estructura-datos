using System;

public class GrafoCiudades {
	private int max = 30;
	private Ciudad[] vertices;
	private int[,] matriz;
	private int n;

	public GrafoCiudades() {
		vertices = new Ciudad[max + 1];
		matriz = new int [max + 1, max + 1];
		n = 0;
	}

	public Ciudad obtenerCiudad(int posicion) => vertices[posicion];

	public int obtenerConexion(int i, int j) => matriz[i, j];

	public int nroVertices() => n;

	public void adicionarVertice(Ciudad elemento) {
		if(n < max) {
			n++;
			vertices[n] = elemento;
		} else
			Console.WriteLine("No se puede adicionar mas ciudades");
	}

	public void adicionarArista(int destino, int origen) {
		// if(origen >= 1 && destino <=n && destino >= 1 && origen <=n) {
		if(origen >= 1 && origen <=n && destino >= 1 && destino <=n) {
			matriz[origen, destino] = 1;
			matriz[destino, origen] = 1;
		} else
			Console.WriteLine("Una de las posiciones es incorrecta");
	}

	public void mostrarVertices() {
		Console.WriteLine("Lista de Ciudades");

		for(int i = 1; i<=n; i++) {
			Console.WriteLine("Posicion Grafo " + i);
			vertices[i].mostrar();
		}
	}

	public void mostrarMatriz() {
		Console.WriteLine("Matriz");

		for(int i =1; i<=n; i++) {
			Console.Write(i+ " -> ");
			for(int j=1; j<=n; j++) {
				Console.Write(matriz[i,j] + " ");
			}
			Console.WriteLine();
		}
	}

	public void mostrarAdyacentes(int posicion) {
		if(posicion >= 1 && posicion <= n) {
			Console.WriteLine("Ciudades conectadas con " + vertices[posicion].getNombre());
			bool existe = false;

			for(int j =1 ; j<=n; j++) {
				if(matriz[posicion, j] == 1) {
					vertices[j].mostrar();
					existe = true;
				}
			}

			if(!existe)
				Console.WriteLine("No tiene ciudades conectadas");
		} else
			Console.WriteLine("Posicion incorrecta");
	}
}
