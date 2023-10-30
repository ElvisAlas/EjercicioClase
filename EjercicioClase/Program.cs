using System;
using System.Timers;

//Clase de super poder
public class SuperPoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Nivel { get; set; }

    //constructor
    public SuperPoder(string nombre, string descripcion, int nivel)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Nivel = nivel;
    }
}

//clase super heroe
 public class SuperHeroe
{
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public bool PuedeVolar { get; set; }
    public SuperPoder SuperPoder { get; set; }

    //constructor
    public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
    {
        Nombre = nombre;
        IdentidadSecreta = identidadSecreta;
        Ciudad = ciudad;
        PuedeVolar = puedeVolar;
        SuperPoder = superPoder;
      
       

    }
    //metodo imprimir
  public  void ImprimirInformacion()
    {
        Console.WriteLine("Información del Superhéroe:");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
        Console.WriteLine($"Ciudad: {Ciudad}");
        Console.WriteLine($"Puede Volar: {PuedeVolar}");
        Console.WriteLine($"Superpoder: {SuperPoder.Nombre}");
        Console.WriteLine($"Descripción: {SuperPoder.Descripcion}");
        Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
        Console.WriteLine();
    }

}

//El constructor
public class Program
{
    
    static void Main()
    {
        SuperPoder poder1 = new SuperPoder("Super Fuerza", "Puede levantar objetos pesados", 7);
        SuperHeroe heroe1 = new SuperHeroe("Hombre Araña", "Peter Parker", "Nueva York", false, poder1);

        SuperPoder poder2 = new SuperPoder("Vuelo", "Puede volar a gran velocidad", 8);
        SuperHeroe heroe2 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, poder2);

        SuperPoder poder3 = new SuperPoder("Invisibilidad", "Puede volverse invisible", 6);
        SuperHeroe heroe3 = new SuperHeroe("Mujer Invisible", "Sue Storm", "Nueva York", false, poder3);

        heroe1.ImprimirInformacion();
        heroe2.ImprimirInformacion();
        heroe3.ImprimirInformacion();

        Console.ReadLine();
    }
}

