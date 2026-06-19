using System;
class HelloWorld {
  static void Main() {
    GrafoCiudades grafo = new GrafoCiudades();
    
    Ciudad c1 = new Ciudad(101, "La Paz", "La Paz", 900000);
    Ciudad c2 = new Ciudad(102, "Cochabamba", "Cochabamba", 850000);
    Ciudad c3 = new Ciudad(103, "Santa Cruz", "Santa Cruz", 1000000);
    Ciudad c4 = new Ciudad(104, "Oruro", "Oruro", 300000);
    Ciudad c5 = new Ciudad(105, "Potosi", "Potosi", 200000);
    
    grafo.adicionarVertice(c1);
    grafo.adicionarVertice(c2);
    grafo.adicionarVertice(c3);
    grafo.adicionarVertice(c4);
    grafo.adicionarVertice(c5);
    
    grafo.adicionarArista(1,2);
    grafo.adicionarArista(1,4);
    grafo.adicionarArista(2,3);
    grafo.adicionarArista(4,5);
    grafo.adicionarArista(4,2);
    
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
    grafo.mostrarVertices();
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
    grafo.mostrarMatriz();
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
    Console.Write("Ingrese la posicion de la ciudad: ");
    int posicion = int.Parse(Console.ReadLine());
    grafo.mostrarAdyacentes(posicion);
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
    // Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
    // Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
  }
}
