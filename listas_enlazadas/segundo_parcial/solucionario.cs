using System;
class HelloWorld {

	// 1. Mostrar cursos de un semestre determinado con sus estudiantes
	// ENTRADA: 3
	// SALIDA: Se muestran INF-131 e INF-151. INF-131 con Lucía y Diego; INF-151 sin estudiantes.

	public static void mostrarCursosYEstudiantes(LDobleCurso a, int semestreX) {
		NodoCurso w = a.getP();
		bool cursoEncontrado = false;

		while(w!=null) {

			if(w.getCurso().getSemestre() == semestreX) {
				Console.WriteLine("====================DATOS DEL CURSO=======================");
				w.getCurso().mostrar();
				Console.WriteLine("====================ESTUDIANTES=======================");
				w.getListaEst().mostrar();

				cursoEncontrado = true;
			}

			w = w.getSig();
		}

		if(!cursoEncontrado)
			Console.WriteLine("No existe el curso del semestre " + semestreX);

	}

	// 2. Contar estudiantes mayores de edad por curso
	// ENTRADA: -
	// SALIDA: INF-111: 2; INF-121: 3; INF-131: 1; INF151: 0.

	public static void contarMayoresEdadXCurso(LDobleCurso a) {
		NodoCurso w = a.getP();

		while(w!=null) {
			int contador = 0;
			LDCircularEst l = w.getListaEst();

			if(l.getP() != null) {
				NodoEst e = l.getP();
				int i = 0;
				int n = l.nroNodos();

				// 1. WHILE
				while(i<n) {
					if(e.getEstudiante().getEdad() >= 18)
						contador++;
					e = e.getSig();
					i++;
				}
				/*// 2. FOR
				for(int i=0;i<n;i++){
				    if(e.getEstudiante().getEdad() >= 18)
						contador++;
					e = e.getSig();
				}
				// 3. TRADICIONAL
				while(e.getSig() != l.getP()){
				     if(e.getEstudiante().getEdad() >= 18)
						contador++;
					e = e.getSig();
				}
				if(e.getEstudiante().getEdad() >= 18)
						contador++;
				// 4. DO WHILE
				do{
				     if(e.getEstudiante().getEdad() >= 18)
						contador++;
					e = e.getSig();
				}while(e.getSig() != l.getP())*/
			}
			Console.WriteLine($"{w.getCurso().getSigla()} : {contador}");
			w = w.getSig();
		}
	}

	// 3. Adicionar un estudiante al curso con menor cantidad de estudiantes
	// ENTRADA: [1010, Elena, 19]
	// SALIDA: Se adiciona al curso INF-151 por ser el de menor cantidad (0).

	// 	public static void adicionarEstudianteACursoConMenorCantidadElementos(LDobleCurso a, Estudiante nuevo) {
	public static void adicionarEstudianteACursoConMenorCantidadElementos(LDobleCurso a) {
		if(a.getP() == null) {
			Console.WriteLine("LA LISTA NO CUENTA CON CURSOS");
			return;
		}

		NodoCurso w = a.getP();
		NodoCurso menor = a.getP();

		while(w != null) {
			if(w.getListaEst().nroNodos() < menor.getListaEst().nroNodos())
				menor = w;
			w = w.getSig();
		}

		// NodoCurso w = a.getP();
		// NodoCurso menor = null;
		// int cantidadEst = 9999999;

		// while(w != null){
		//     LDCircularEst l = w.getListaEst();

		//     if(l.nroNodos() < cantidadEst)
		//         menor = w;
		//    w = w.getSig();
		// }

		Console.WriteLine("CURSO CON MENOR CANTIDAD DE ESTUDIANTES");
		menor.getCurso().mostrar();

		Console.WriteLine("INGRESE LOS DATOS DEL NUEVO ESTUDIANTE");
		Estudiante nuevo = new Estudiante();
		nuevo.leer();

		menor.getListaEst().adiFinal(nuevo);
	}
	// 4. Mostrar estudiantes en orden inverso de un curso específico
	// ENTRADA: INF-121
	// SALIDA: Bruno, Sofía, Mario, Carla.

	public static void mostrarOrdenInverso(LDobleCurso a, string curso) {
		NodoCurso w = a.getP();
		bool cursoEncontrado = false;

		while( w!= null) {

			// INF-111, INF-121, INF-131
			//inf-111
			if(w.getCurso().getSigla().ToUpper() == curso.ToUpper()) {
				cursoEncontrado = true;

				LDCircularEst l = w.getListaEst();

				if(l.getP() == null) {
					Console.WriteLine("El curso no tiene estudiantes");
				} else {
					NodoEst e = l.getP().getAnt();
					int i = 0;
					int n = l.nroNodos();

					while(i<n) {
						Console.Write(e.getEstudiante().getNombre() + ", "); // e.getEstudiante().mostrar();
						e = e.getAnt();
						i++;
					}

					// for(int i = 0; i < l.nroNodos(); i++){
					//     Console.Write(e.getEstudiante().getNombre() + ", "); // e.getEstudiante().mostrar();
					//     e = e.getAnt();
					// }


					// 	NodoEst ultimo = l.getP().getAnt()
					// 	while(e.getAnt() != ultimo){
					// 	    Console.Write(e.getEstudiante().getNombre() + ", "); // e.getEstudiante().mostrar();
					// 		e = e.getAnt();
					// 	}
					// 	Console.Write(l.getP().getEstudiante().getNombre() + ", "); // e.getEstudiante().mostrar();
				}
			}
			w = w.getSig();
		}

		if(!cursoEncontrado)
			Console.WriteLine("No se encontro el curso con la sigla " + curso);
	}

	// 5. Mostrar el curso con mayor cantidad de estudiantes
	// 	ENTRADA: -
	// 	SALIDA: Curso con mayor cantidad: INF-121. Cantidad: 4.
	public static void mostrarCursoConMasEstudiantes(LDobleCurso a) {
		if(a.getP() == null) {
			Console.WriteLine("No existen cursos registrados");
			return;
		}

		NodoCurso w = a.getP();
		NodoCurso mayor = a.getP();

		while( w != null ) {

			if(w.getListaEst().nroNodos() > mayor.getListaEst().nroNodos())
				mayor = w;

			w = w.getSig();
		}

		Console.WriteLine(mayor.getCurso().getSigla() + " Cantidad: " + mayor.getListaEst().nroNodos() +" estudiantes");
		mayor.getCurso().mostrar();
		mayor.getListaEst().mostrar();
	}

	// 6. Eliminar el primer estudiante de cada curso
	// ENTRADA: -
	// SALIDA: INF-111 elimina Ana; INF-121 elimina Carla; INF-131 elimina Lucía; INF-151 no cambia.
	public static void eliminarPrimerEstudiaTodosLosCursos(LDobleCurso a) {
		NodoCurso w = a.getP();

		while( w != null) {
			LDCircularEst l = w.getListaEst();

			if( l.getP() == null) {
				Console.WriteLine("El curso no tiene estudiantes");
			} else {
				NodoEst eliminado = l.getP();

				if(eliminado.getSig() == eliminado) {
					l.setP(null);
					eliminado.setSig(null);
					eliminado.setAnt(null);
				} else {
					NodoEst ultimo = eliminado.getAnt();
					NodoEst nuevoPrimer = eliminado.getSig();

					ultimo.setSig(nuevoPrimer);
					nuevoPrimer.setAnt(ultimo);

					l.setP(nuevoPrimer);

					eliminado.setSig(null);
					eliminado.setAnt(null);
				}
				Console.WriteLine("En el curso " + w.getCurso().getSigla() + " se elimino " + eliminado.getEstudiante().getNombre());
			}
			w = w.getSig();
		}

		// 		while( w!=null) {
		// 			LDCircularEst l = w.getListaEst();
		// 			if( l.getP() == null) {
		// 				Console.WriteLine("El curso no tiene estudiantes");
		// 			} else {
		// 				NodoEst eliminado = l.eliPrincipio();
		// 				Console.WriteLine("En el curso " + w.getCurso().getSigla() + " se elimino " + eliminado.getEstudiante().getNombre());
		// 			}
		//          w = w.getSig();
		// 		}
	}

	//7. Eliminar cursos que no tengan estudiantes
	// ENTRADA: -
	// SALIDA: Se elimina el curso INF-151 de la lista principal.
	public static void eliminarCursosSinEstudiantes(LDobleCurso a) {
		NodoCurso w = a.getP();
		int cursosEliminados = 0;

		while(w != null ) {
			NodoCurso siguiente = w.getSig();

			// if(w.getListaEst().nroNodos() == 0){
			if(w.getListaEst().getP() == null) {
				cursosEliminados++;

				if(w.getSig() == null && w.getAnt() == null) {
					a.setP(null);
				} else if(w.getAnt() == null) {
					a.setP(w.getSig());
					a.getP().setAnt(null);

					w.setSig(null);
				} else if( w.getSig() == null) {
					w.getAnt().setSig(null);
					w.setAnt(null);
				} else {
					NodoCurso anterior = w.getAnt();
					NodoCurso sig = w.getSig();

					anterior.setSig(sig);
					sig.setAnt(anterior);

					w.setSig(null);
					w.setAnt(null);
				}
			}
			w = siguiente;
		}
		Console.WriteLine("Cantidad de Cursos eliminados: " + cursosEliminados);
	}

	// 8. Mover el primer estudiante de un curso origen a un curso destino
	// ENTRADA: Origen: INF-111; Destino: INF-131
	// SALIDA: Se mueve Ana al final de INF-131. INF-111 queda con Luis y Pedro. INF-131 queda con Lucía, Diego y Ana.
	public static void moverEstudianteCursoOrigenADestino(LDobleCurso a, string siglaOrigen, string siglaDestino) {
		if(siglaOrigen.ToUpper() == siglaDestino.ToUpper()) {
			Console.WriteLine("El curso destino y origen no pueden ser iguales");
			return;
		}

		NodoCurso w = a.getP();
		NodoCurso origen = null;
		NodoCurso destino = null;

		while( w != null ) {
			if(w.getCurso().getSigla().ToUpper() == siglaOrigen.ToUpper()) {
				origen = w;
			}
			if(w.getCurso().getSigla().ToUpper() == siglaDestino.ToUpper()) {
				destino = w;
			}
			w = w.getSig();
		}

		if(origen == null || destino == null) {
			Console.WriteLine("No se encontro el curso origen o destino");
			return;
		}

		LDCircularEst lorigen = origen.getListaEst();
		LDCircularEst ldestino = destino.getListaEst();

		NodoEst eliminado = lorigen.eliPrincipio();
		Estudiante est = eliminado.getEstudiante();

		ldestino.adiFinal(est);
	}

	// 9. Eliminar estudiantes con una edad exacta en un curso específico
	// ENTRADA: Curso: INF-121; Edad: 17
	// SALIDA: Se elimina a Bruno. Quedan Carla, Mario y Sofía.
	public static void eliminarEstudianteXEdadYCurso(LDobleCurso a, string sigla, int edad) {
		NodoCurso w = a.getP();
		bool encontrado = false;
		int eliminados = 0;

		while(w!= null) {
			if(w.getCurso().getSigla().ToUpper() == sigla.ToUpper()) {
				encontrado = true;

				LDCircularEst l = w.getListaEst();

				if(l.getP() == null) {
					Console.WriteLine("El curso no tiene estudiantes para eliminar");
				} else {
					int total = l.nroNodos();
					int i = 0;

					NodoEst e = l.getP();

					while(i < total && l.getP() != null) {
						NodoEst siguiente = e.getSig();

						if(e.getEstudiante().getEdad() == edad) {
							eliminados++;
							//[e1]
							if(e.getSig() == e) {
								l.setP(null);
							} else {
								NodoEst anterior = e.getAnt();

								anterior.setSig(siguiente);
								siguiente.setAnt(anterior);

								if(e == l.getP()) {
									l.setP(siguiente);
								}
							}
							e.setSig(null);
							e.setAnt(null);
						}
						e = siguiente;
						i++;
					}
				}
			}
			w= w.getSig();
		}
		if(encontrado)
			Console.WriteLine("Cnatidfad de estudiantes eliminados " + eliminados);
		else
			Console.WriteLine("No existe el curso con la sigla "+ sigla);
	}
    
    //10. Intercambiar las listas de estudiantes entre dos cursos
    // ENTRADA: INF-111 e INF-131 
    // SALIDA: INF-111 pasa a tener Lucía y Diego; INF131 pasa a tener Ana, Luis y Pedro.
    public static void intercambiarEstudiantesDosCursos(LDobleCurso a, string cursoA, string cursoB){
        cursoA = cursoA.ToUpper();
        cursoB = cursoB.ToUpper();
        if(cursoA == cursoB){
            Console.WriteLine("LOS CURSOS PARA EL INTERCAMBIO DEBEN SER DISTINTOS");
            return;
        }
        
        NodoCurso w = a.getP();
        NodoCurso c1 = null;
        NodoCurso c2 = null;
        
        while(w!=null){
            if(w.getCurso().getSigla().ToUpper() == cursoA)
                c1 = w;
            if(w.getCurso().getSigla().ToUpper() == cursoB)
                c2 = w;
            w = w.getSig();
        }
        
        if(c1==null || c2 ==null){
            Console.WriteLine("No se encontro uno de los dos cursos");
            return;
        }
        LDCircularEst aux = c1.getListaEst();
        
        c1.setListaEst(c2.getListaEst());
        c2.setListaEst(aux);
    }
    
	static void Main() {
		LDobleCurso a = new LDobleCurso();
		Console.Write("INGRESE LA CANTIDAD DE CURSOS: ");
		int n = int.Parse(Console.ReadLine());
		a.leerFinal(n);

		a.mostrar();

		// 		Console.WriteLine("***************************************************");
		// 		Console.Write("INGRESE SIGLA: ");
		// 		string sigla = Console.ReadLine();
		// 		mostrarEstudiantesCursoX(a, sigla);


		// 		Console.WriteLine("***************************************************");
		// 		contarEstudiantesCurso(a);

		// 		string sigla = Console.ReadLine();
		// 		eliminarEstudiantesXEdadYCurso(a, sigla);
		// 		a.mostrar();

	}
}
