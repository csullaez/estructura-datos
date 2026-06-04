
using System;
class HelloWorld {

	// 1	Mostrar proyectos de un estudiante
	//Entrada: Juan
	//Salida: [Sistema Web, Juan, 80, Sistemas, 2025, Aprobado] y [Inventario TI, Juan, 30, Sistemas, 2025, Reprobado]

	public static void proyectosXEstudiante(PilaColasProyecto pila, string estudianteX) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getNombreEstudiante() == estudianteX) {
					p.mostrar();
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}

	// 	2	Contar proyectos por estudiante en una gestión
	// Entrada 2025
	// Salida Juan: 2, Pedro: 1, María: 1

	public static void contarProyectosXEstudianteGestion(PilaColasProyecto pila, int gestion) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		string[] estudiantes = new string[50];
		int[] contadores = new int[50];
		int n = 0;

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getGestion() == gestion) {
					string nombre = p.getNombreEstudiante();
					int pos = -1;

					for(int i = 0; i<n; i++) {
						if(estudiantes[i] == nombre) {
							pos = i;
						}
					}

					if(pos == -1) {
						estudiantes[n] = nombre;
						contadores[n] = 1;
						n++;
					} else {
						contadores[pos]++;
					}
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);

		for(int d = 0; d<n; d++) {
			Console.WriteLine(estudiantes[d]+": "+contadores[d]);
		}
	}

	// 3	Mostrar proyectos aprobados
	// Entrada —
	// Salida Sistema Web, App Móvil, Firewall Escolar
	public void proyectosAprobados(PilaColasProyecto pila) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getNota() >= 51 || p.getEstado() == "Aprobado") {
					Console.WriteLine(p.getTitulo()); // p.mostrar();
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}

	// 4	Actualizar estado según nota
	// Entrada —
	// Salida Nota >= 51 queda Aprobado; nota < 51 queda Reprobado. Auditoría Red pasa de Pendiente a Reprobado

	public void actualizarEstadoXNota(PilaColasProyecto pila) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();

				if(p.getNota() >= 51) {
					p.setEstado("Aprobado");
				} else {
					p.setEstado("Reprobado");
				}
				auxCola.adicionar(p);
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}

	// 5	Mostrar proyectos de un área
	// 	Entrada: Sistemas
	// 	Salida: Sistema Web, App Móvil, Inventario TI

	public static void proyectosXArea(PilaColasProyecto pila, string areaX) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getArea() == areaX) {
					Console.WriteLine(p.getTitulo()); // p.mostrar();
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}

	// 6	Contar proyectos por área
	// 	Entrada: —
	// 	Salida: Sistemas: 3, Redes: 1, Seguridad: 2

	public static void contarProyectosXArea(PilaColasProyecto pila) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		string[] areas = new string[50];
		int[] contadores = new int[50];
		int n = 0;

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				string area = p.getArea();
				int pos = -1;

				for(int i = 0; i < n ; i++) {
					if(areas[i] == area) {
						pos = i;
					}
				}

				if(pos == -1) {
					areas[n] = area;
					contadores[n] = 1;
					n++;
				} else {
					contadores[pos]++;
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);

		for(int d=0; d<n; d++) {
			Console.WriteLine(areas[d] + ": "+ contadores[d]+ "proyecto(s)");
		}
	}

	// 7	Mostrar proyectos de una gestión
	// 	Entrada: 2025
	// 	Salida: Sistema Web, Red LAN, Firewall Escolar, Inventario TI

	public static void proyectosXGestion(PilaColasProyecto pila, int gestionX) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				if(p.getGestion()==gestionX) {
					Console.WriteLine(p.getTitulo());
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);
	}

	// 8	Mostrar mayor nota por área
	// 	Entrada: —
	// 	Salida: Sistemas: App Móvil 90; Redes: Red LAN 45; Seguridad: Firewall Escolar 70

	public static void mayorNotaXArea(PilaColasProyecto pila) {
		PilaColasProyecto auxPila = new PilaColasProyecto();

		string[] areas = new string[50];
		Proyecto[] mejores = new Proyecto[50];
		int n = 0;

		while(!pila.esVacia()) {
			ColaCircularProyecto cola = pila.eliminar();
			auxPila.adicionar(cola);

			ColaCircularProyecto auxCola = new ColaCircularProyecto();

			while(!cola.esVacia()) {
				Proyecto p = cola.eliminar();
				auxCola.adicionar(p);

				string area = p.getArea();
				int pos = -1;

				for(int i=0; i<n; i++) {
					if(areas[i] == area) {
						pos = i;
					}
				}

				if(pos == -1) {
					areas[n] = area;
					mejores[n] = p;
					n++;
				} else {
					if(p.getNota() > mejores[pos].getNota()) {
						mejores[pos] = p;
					}
				}
			}
			cola.vaciar(auxCola);
		}
		pila.vaciar(auxPila);

		// 	Salida: Sistemas: App Móvil 90; Redes: Red LAN 45; Seguridad: Firewall Escolar 70
		for(int i=0; i<n; i++) {
			Console.WriteLine("Mayor nota del area: "+ areas[i]+": ");
			mejores[i].mostrar();
		}
	}

	// 9	Mostrar proyectos pendientes
	// 	Entrada: —
	// 	Salida: Auditoría Red
	
	public static void proyectosPendientes(PilaColasProyecto pila){
	    PilaColasProyecto auxPila = new PilaColasProyecto();
	    
	    while(!pila.esVacia()){
	        ColaCircularProyecto cola = pila.eliminar();
	        auxPila.adicionar(cola);
	        
	        ColaCircularProyecto auxCola = new ColaCircularProyecto();
	        
	        while(!cola.esVacia()){
	            Proyecto p = cola.eliminar();
	            auxCola.adicionar(p);
	            
	            if(p.getEstado() == "Pendiente"){
	                Console.WriteLine(p.getTitulo());
	            }
	        }
	        cola.vaciar(auxCola);
	    }
	    pila.vaciar(auxPila);
	}

	// 10	Mover reprobados a una nueva cola	
	// Entrada: —	
	// Salida: Nueva cola: Red LAN, Inventario TI. La pila original queda sin esos proyectos
	
	public static ColaCircularProyecto moverACola(PilaColasProyecto pila){
	    PilaColasProyecto auxPila = new PilaColasProyecto();
	    ColaCircularProyecto reprobados = new ColaCircularProyecto();
	    
	    while(!pila.esVacia()){
	        ColaCircularProyecto cola = pila.eliminar();
	        
	        ColaCircularProyecto auxCola = new ColaCircularProyecto();
	        
	        while(!cola.esVacia()){
	            Proyecto p = cola.eliminar();
	            
	            if(p.getEstado() == "Reprobado"){
	                reprobados.adicionar(p);
	            } else{
	                auxCola.adicionar(p);
	            }
	        }
	        auxPila.adicionar(auxCola);
	    }
	    pila.vaciar(auxPila);
	    
	    return reprobados;
	}
	
	// Tarea: Invocar y utlizar todos los metodos del Solucionario

	static void Main() {
		PilaColasProyecto p1 = new PilaColasProyecto();
		Console.Write("Ingrese la cantidad de COLAS PARA LA PILA: ");
		int n = int.Parse(Console.ReadLine());

		p1.llenar(n);
		p1.mostrar();


	}
}
