using System;
class HelloWorld {
  static void Main() {
    LSimpleString l = new LSimpleString();
    Console.Write("Ingrese la cantidad de estudiantes: ");
    int n = int.Parse(Console.ReadLine());
    
    l.leerFinal(n);
    
    l.mostrar();
    
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("CANTIDAD DE ESTUDIANTES: "+ l.nroNodos());
    
    Console.WriteLine("+++++++++++++++++ADICIONAR PRINCIPIO+++++++++++++++++++++++++++++++++++++");
    Console.Write("Ingrese el nombre del nuevo estudiante: ");
    string nuevo = Console.ReadLine();
    l.adicionarPrincipio(nuevo);
    
    Console.WriteLine("+++++++++++++++++ADICIONAR FINAL+++++++++++++++++++++++++++");
    Console.Write("Ingrese el nombre del nuevo estudiante: ");
    nuevo = Console.ReadLine();
    l.adicionarFinal(nuevo);
    
    Console.WriteLine("+++++++++++++++++ESTUDIANTES+++++++++++++++++++++++++++++++++");
    l.mostrar();
    Console.WriteLine("++++++++++++++++++ELIMINAR+++++++++++++++++++++++++++++++++");
    NodoString eliminado = l.eliminarPrincipio();
    if(eliminado != null){
        Console.WriteLine("Estudiante eliminado: "+ eliminado.getNombre());
    } else {
        Console.WriteLine("Lista VACIA");
    }
    
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    l.mostrar();
  }
}
