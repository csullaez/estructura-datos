
using System;
class HelloWorld {

	// MOSTRAR LA CANTIDAD DE PROYECTOS DE UN ESTUDIANTE E

	public static void cantidadProyectosEstudianteE(PilaColasProyecto pila, string estudiante) {
		PilaColasProyecto auxPila = new PilaColasProyecto();
		int contador = 0;

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getNombreEstudiante() == estudiante) {
					contador++;
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);

		Console.WriteLine("El estudiante " + estudiante + " tiene "+ contador +" proyecto(s)");
	}


	// MOSTRAR TODOS LOS PROYECTOS CON NOTAS MAYORES A X
	// 1. RECORRER LA PILA DE COLAS
	//      1.1 RECORRER LAS COLAS DE PROYECTOS
	//          1.1.1 VERIFICAR CADA NOTA DE PROYECTO CON X

	public static void mostrarProyectosNotaMayorX(PilaColasProyecto pila, int notaX) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getNota() > notaX) {
					p.mostrar();
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}


	static void Main() {
		PilaColasProyecto p1 = new PilaColasProyecto();
		Console.Write("Ingrese la cantidad de COLAS PARA LA PILA: ");
		int n = int.Parse(Console.ReadLine());

		p1.llenar(n);
		p1.mostrar();

		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
		Console.Write("Ingrese la nota para filtrar proyectos: ");
		int nota = int.Parse(Console.ReadLine());

		mostrarProyectosNotaMayorX(p1, nota);

		Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
		Console.Write("Ingrese el nombre del estudiante para ver sus proyectos: ");
		string nombreEstudiante = Console.ReadLine();
		cantidadProyectosEstudianteE(p1, nombreEstudiante);
	}
}
