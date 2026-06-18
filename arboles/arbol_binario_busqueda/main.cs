using System;
class HelloWorld {
    // 1. Mostrar automoviles por marca X
    public static void mostrarAutoPorMarca(NodoAutomovil r, string marcaX) {
        if( r != null ){
            if(r.getAutomovil().getMarca() == marcaX){
                r.getAutomovil().mostrar();
            }
            mostrarAutoPorMarca(r.getIzq(), marcaX);
            mostrarAutoPorMarca(r.getDer(), marcaX);
        }
    }
    
    // 2. Contar y mostrar automoviles del anio X
    public static int contarMostrarAutoAnioX(NodoAutomovil r, int anioX) {
        if( r == null)
            return 0;
        int cantidad = 0;
        
        if(anioX < r.getAutomovil().getAnio())
            cantidad = cantidad + contarMostrarAutoAnioX(r.getIzq(), anioX);
        else if(anioX > r.getAutomovil().getAnio())
            cantidad = cantidad + contarMostrarAutoAnioX(r.getDer(), anioX);
        else {
            cantidad = cantidad + contarMostrarAutoAnioX(r.getIzq(), anioX);
            
            r.getAutomovil().mostrar();
            cantidad++;
            
            cantidad = cantidad + contarMostrarAutoAnioX(r.getDer(), anioX);
        }
        
        return cantidad;
    }
    
	static void Main() {
		ABBAutomovil arbol = new ABBAutomovil();

		Automovil a1 = new Automovil("TOYOTA", "1890-ERT", "MINIBUS", "Rojo", 2025);
		Automovil a2 = new Automovil("NISSAN", "654-RTY", "BUS", "Verde", 2022);
		Automovil a3 = new Automovil("MITSUBISHI", "147-TYU", "CAMIONETA", "Azul", 1999);
		Automovil a4 = new Automovil("NISSAN", "852-QWE", "TAXI", "Rosado", 2015);
		Automovil a5 = new Automovil("MITSUBISHI", "369-YUI", "CAMIONETA", "Azul", 2000);
		Automovil a6 = new Automovil("SUZUKI", "753-ASD", "TAXI", "Azul", 2005);
		Automovil a7 = new Automovil("NISSAN", "951-XCB", "CAMIONETA", "Rojo", 2023);
		Automovil a8 = new Automovil("SUZUKI", "189-JJK", "MINIBUS", "Verde", 2021);
		Automovil a9 = new Automovil("MITSUBISHI", "761-JKL", "TAXI", "Rosado", 2020);
		Automovil a10 = new Automovil("NISSAN", "890-SDF", "BUS", "Rojo", 1998);
		Automovil a11 = new Automovil("TOYOTA", "346-SHK", "CAMIONETA", "Rojo", 2005);
		Automovil a12 = new Automovil("NISSAN", "876-QWE", "BUS", "Verde", 2026);

		arbol.insertar(a1);
		arbol.insertar(a2);
		arbol.insertar(a3);
		arbol.insertar(a4);
		arbol.insertar(a5);
		arbol.insertar(a6);
		arbol.insertar(a7);
		arbol.insertar(a8);
		arbol.insertar(a9);
		arbol.insertar(a10);
		arbol.insertar(a11);
		arbol.insertar(a12);

		// string nMarca, string nPlaca, string nModelo, string nColor, ina nAnio

		Console.Write("Ingrese la cantidad de automoviles que desea insertar: ");
		int n = int.Parse(Console.ReadLine());

		for(int i = 1; i<=n; i++) {
			Console.WriteLine("DATOS DEL AUTOMOVIL " + i);
			Automovil nuevo = new Automovil();
			nuevo.leer();

			arbol.insertar(nuevo);
		}

		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>PREORDEN>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		arbol.preorden(arbol.getRaiz());
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>INORDEN>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		arbol.inorden(arbol.getRaiz());
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>POSTORDEN>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		arbol.postorden(arbol.getRaiz());
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		Console.Write("Ingrese la marca que sea buscar: ");
		string marca = Console.ReadLine().ToUpper();
		mostrarAutoPorMarca(arbol.getRaiz(), marca);
		Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		Console.Write("Ingrese la anio que desea buscar: ");
		int anio = int.Parse(Console.ReadLine());
		Console.WriteLine("Cantidad de automoviles del anio " + anio + ": "+ contarMostrarAutoAnioX(arbol.getRaiz(), anio));
		// Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		// Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
	}
}
