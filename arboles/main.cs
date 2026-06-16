using System;
class HelloWorld {

	// 1. Buscar una materia por su codigo y mostrar a sus estudiantes
	public static bool mostrarMateriaYEstudiantes(NodoMateria r, string codigo) {
		bool encontrado = false;

		if( r!= null ) {
			if(r.getMateria().getCodigo().ToUpper() == codigo.ToUpper()) {
				Console.WriteLine("-----------------------DATOS DE LA MATERIA-----------------------");
				r.getMateria().mostrar();
				encontrado = true;
			}

			bool encontradoIzq = mostrarMateriaYEstudiantes(r.getIzq(), codigo);
			bool encontradoDer = mostrarMateriaYEstudiantes(r.getDer(), codigo);

			encontrado = encontrado || encontradoIzq || encontradoDer;
		}

		return encontrado;
	}
	
	public void mostrarMateriaYEstudiantesPrincipal(NodoMateria r){
	    Console.Write("Ingrese el codigo de la materia: ");
		string codigo = Console.ReadLine();
		bool encontrado = mostrarMateriaYEstudiantes(r, codigo);
		if(!encontrado)
			Console.WriteLine("No se encontro ninguna materia con el codigo: " + codigo);
	}

	static void Main() {
		ABinarioMaterias a = new ABinarioMaterias();
		a.setRaiz(new NodoMateria());

		a.crear(a.getRaiz());

		Console.WriteLine("#############################PREORDEN############################################");
		a.preorden(a.getRaiz());
		Console.WriteLine("#############################INORDEN#############################################");
		a.inorden(a.getRaiz());
		Console.WriteLine("#############################POSTORDEN###########################################");
		a.postorden(a.getRaiz());
		Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
		mostrarMateriaYEstudiantesPrincipal(a.getRaiz());
		Console.WriteLine("///////////////////////////////////////////////////////////////////////////");
		// 		Console.WriteLine("#####################################################");
		// 		Console.WriteLine("#####################################################");
	}
}
