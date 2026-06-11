using System;
class HelloWorld {

	static void Main() {
		LDobleCurso a = new LDobleCurso();
		Console.Write("INGRESE LA CANTIDAD DE CURSOS: ");
		int n = int.Parse(Console.ReadLine());
		a.leerFinal(n);

		a.mostrar();

	}
}
