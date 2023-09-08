using System;
using System.Collections.Generic;

public class Estudiantes
{
    public Estudiantes(int cod, String nombre, String correo, int edad, String direccion)
    {
        this.cod = cod;
        this.nombre = nombre;
        this.correo = correo;
        this.edad = edad;
        this.direccion = direccion;
    }
    public int cod
    {
        get {return cod;}
        set {cod = value; }
    }
    public String nombre
    {
        get {return nombre; }
        set {nombre = value;}
    }
    public String correo
    {
        get {return correo;}
        set {correo = value;}
    }
    public int edad
    {
        get {return edad;}
        set {edad = value;}
    }
    public String direccion
    {
        get {return direccion;}
        set {direccion = value;}
    }
    

    public static void crearEstadiantes(List<Estudiantes> lsEstudiantes)
    {
        Console.WriteLine("Ingrese la cantidad de estudiantes que desea registrar:");
        int cantidad = int.Parse(Console.ReadLine());
        int agregados = 0;
        while (agregados < cantidad)
        {
            try
            {
                    Console.Write("\nIngrese el Codigo del estudiante:");
                    String? cod = Console.ReadLine();
                    Console.Write("Ingrese el nombre del estudiante:");
                    String? nom = Console.ReadLine();
                    Console.Write($"Ingrese el correo del estudiante {nom}:");
                    String? correo = Console.ReadLine();
                    Console.Write($"Ingrese la edad del estudiante {nom}:");
                    String? edad = Console.ReadLine();
                    Console.Write($"Ingrese la direccion del estudiante {nom}:");
                    String? direccion = Console.ReadLine();

                    if()
            }
            catch {

            }
        }
    }


}