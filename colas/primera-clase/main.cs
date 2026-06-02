using System;
class HelloWorld {

    static void mayorSuperficie(ColaSimpleDepto a){
        ColaSimpleDepto aux = new ColaSimpleDepto();
        Departamento mayor = a.eliminar();
        aux.adicionar(mayor);
        
        while(!a.esVacia()){
            Departamento d = a.eliminar();
            aux.adicionar(d);
            
            if(d.getSuperficie() > mayor.getSuperficie()){
                mayor = d;
            }
        }
        
        while(!aux.esVacia()){
            Departamento d = aux.eliminar();
            a.adicionar(d);
            
            if(d.getSuperficie() == mayor.getSuperficie()){
                d.mostrar();
            }
        }
    }
    
	static void Main() {
		ColaSimpleDepto c1 = new ColaSimpleDepto();

		Console.Write("Ingrese la cantidad de Departamentos: ");
		int n = int.Parse(Console.ReadLine());

		c1.llenar(n);

		c1.mostrar();
		
		Console.WriteLine("---------------------------------");
		mayorSuperficie(c1);
	}
}
