using System;
class HW {

	public static void agrupar(PilaEstudiantes pilaEstudiantes, PilaEvaluaciones pilaEvaluaciones) {
		PilaEstudiantes estudianteAuxiliar = new PilaEstudiantes();
		PilaEvaluaciones evaluacionesAuxiliar = new PilaEvaluaciones();
		PilaEvaluaciones agrupados = new PilaEvaluaciones();

		while(!pilaEstudiantes.esVacia()) {

			Estudiante elemento = pilaEstudiantes.eliminar();
			estudianteAuxiliar.adicionar(elemento);

			while(!pilaEvaluaciones.esVacia()) {
				Evaluacion eval = pilaEvaluaciones.eliminar();

				if(eval.getCi() == elemento.getCi()) {
					agrupados.adicionar(eval);
				} else {
					evaluacionesAuxiliar.adicionar(eval);
				}
			}
			pilaEvaluaciones.vaciar(evaluacionesAuxiliar);
		}
		pilaEstudiantes.vaciar(estudianteAuxiliar);
		pilaEvaluaciones.vaciar(agrupados);
	}
	
	public static void ordenarEvaluaciones(PilaEvaluaciones m){
	    PilaEvaluaciones a = new PilaEvaluaciones();
	    PilaEvaluaciones b = new PilaEvaluaciones();
	    
	    while(!m.esVacia()){
	        Evaluacion elemento = m.eliminar();
	        
	        while(!m.esVacia()){
	            Evaluacion x = m.eliminar();
	            
	            if(x.getNota() > elemento.getNota()){
	                a.adicionar(elemento);
	                elemento = x; 
	            } else {
	                a.adicionar(x);
	            }
	        }
	        b.adicionar(elemento);
	        m.vaciar(a);
	    }
	    m.vaciar(b);
	}

	public static void Main() {
		// Estudiante e1 = new Estudiante();
		// e1.leer();
		// e1.mostrar();
		PilaEstudiantes p1 = new PilaEstudiantes();
		PilaEvaluaciones e1 = new PilaEvaluaciones();

// 		Console.Write("INGRESE LA CANTIDAD DE ESTUDIANTES: ");
// 		int n = int.Parse(Console.ReadLine());
// 		p1.llenar(n);


		Console.Write("INGRESE LA CANTIDAD DE EVALUACIONES: ");
		int m = int.Parse(Console.ReadLine());
		e1.llenar(m);

		Console.WriteLine("*******DATOS COMPLETOS******* ");
// 		p1.mostrar();
		e1.mostrar();

		// AGRUPAR LAS EVALUACIONES DE ACUERDO AL ORDEN DE LOS ESTUDIANTES
		// ENTRADA
		// p1 = [ es1, es2, es5, es4
		// e1 = [ e1-es3, e2-es4, e3-es2, e4-es2
		// SALIDA
		// p1 = [ es1, es2, es5, es4
		// e1 = [ e3-es2, e4-es2, e2-es4, e1-es3
        // invocar
        // agrupar(p1, e1);
        // // mostrar
        // p1.mostrar();
        // e1.mostrar();


        // ORDENAR EVALUACIONES
        ordenarEvaluaciones(e1);
        e1.mostrar();


        // PRUEBAS DE ESCRITORIO A MANO DE EJERCICIOS 
        // POR METODO
        
        // ORDENAR Y AGRUPAR
        // Mientras agrupes evaluaciones por estudiantes
        // al mismo tiempo debes ordenar las evaluaciones







	}
}
