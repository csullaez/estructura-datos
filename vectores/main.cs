using System;
using System.Collections.Generic;

class HelloWorld {

	static void RecorrerArray(int[] numeros, int indice) {
		if(indice == numeros.Length) {
			return;
		}
		Console.Write(numeros[indice] + " ");
		RecorrerArray(numeros, indice + 1);
	}

	static void MostrarPares(int[] numeros, int indice) {
		if(indice == numeros.Length) {
			return;
		}
		if(numeros[indice] %2==0) {
			Console.Write(numeros[indice] + " ");
		}
		MostrarPares(numeros, indice + 1);
	}
	
	static int SumaRecursiva(int[] numeros, int indice){
	    if(indice == numeros.Length){
	        return 0;
	    }
	    return numeros[indice] + SumaRecursiva(numeros, indice + 1);
	}

	static void Main() {
		// RECURSIVIDAD: Ejecutar una tarea e invocarla nuevamente
		int[] numeros = {5, 10, 15, 20, 25};
		RecorrerArray(numeros, 0);
		
        Console.WriteLine("\n MOSTAR NUMEROS PARES");
		// MOSTRAR LOS NUMEROS PARES DEL ARRAY
		// Entrada: {5, 10, 15, 20, 25}
		// Salida: 10, 20
        MostrarPares(numeros, 0);
        // DEFINIR UN METODO QUE ME RETORNE LA SUMA TOTAL DE UN ARRAY (RECURSIVIDAD)
		// Entrada: {5, 10, 15, 20, 25}
		// Salida: 75
		Console.WriteLine("\nLa suma es: " + SumaRecursiva(numeros, 0));

	}
}
