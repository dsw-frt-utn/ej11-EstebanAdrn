using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Juan", 8.5);
        Alumno alumno2 = new Alumno(2, "Ana", 9.2);
        Alumno alumno3 = new Alumno(3, "Pedro", 7.4);

        casoList.Agregar(alumno1);
        casoList.Agregar(alumno2);
        casoList.Agregar(alumno3);

        Console.WriteLine("Lista de alumnos:");
        MostrarAlumnos(casoList.Listar());

        Console.WriteLine("\nBuscar alumno existente:");
        Alumno? encontrado = casoList.BuscarPorNombre("Ana");

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente:");
        Alumno? noEncontrado = casoList.BuscarPorNombre("Carlos");

        if (noEncontrado != null)
        {
            Console.WriteLine(noEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminar un alumno:");
        casoList.Eliminar(alumno2);
        MostrarAlumnos(casoList.Listar());

        Console.WriteLine("\nEliminar primer elemento:");
        casoList.EliminarEnPosicion(0);
        MostrarAlumnos(casoList.Listar());
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1001, "Lucas", 8.1);
        Alumno alumno2 = new Alumno(1002, "María", 9.6);
        Alumno alumno3 = new Alumno(1003, "Sofía", 7.8);

        casoDictionary.Agregar(alumno1);
        casoDictionary.Agregar(alumno2);
        casoDictionary.Agregar(alumno3);

        Console.WriteLine("Diccionario de alumnos:");
        MostrarDiccionario(casoDictionary.Listar());

        Console.WriteLine("\nBuscar alumno existente por clave:");
        Alumno? encontrado = casoDictionary.BuscarPorClave(1002);

        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente por clave:");
        Alumno? noEncontrado = casoDictionary.BuscarPorClave(9999);

        if (noEncontrado != null)
        {
            Console.WriteLine(noEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nEliminar alumno por clave:");
        casoDictionary.Eliminar(1001);
        MostrarDiccionario(casoDictionary.Listar());
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(FormatearLibro(casoLinq.GetPrimero()));

        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(FormatearLibro(casoLinq.GetUltimo()));

        Console.WriteLine("\nTotal de precios:");
        Console.WriteLine(casoLinq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\nPromedio de precios:");
        Console.WriteLine(casoLinq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\nLibros con Id mayor a 15:");
        MostrarLibros(casoLinq.GetListById());

        Console.WriteLine("\nLibros con título y precio en formato moneda:");
        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibro con mayor precio:");
        Console.WriteLine(FormatearLibro(casoLinq.GetMayorPrecio()));

        Console.WriteLine("\nLibro con menor precio:");
        Console.WriteLine(FormatearLibro(casoLinq.GetMenorPrecio()));

        Console.WriteLine("\nLibros con precio mayor al promedio:");
        MostrarLibros(casoLinq.GetMayorPromedio());

        Console.WriteLine("\nLibros ordenados por título descendente:");
        MostrarLibros(casoLinq.GetOrdenadosPorTituloDescendente());
    }

    private static void MostrarAlumnos(List<Alumno> alumnos)
    {
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }
    }

    private static void MostrarDiccionario(Dictionary<int, Alumno> alumnos)
    {
        foreach (KeyValuePair<int, Alumno> item in alumnos)
        {
            Console.WriteLine($"Legajo: {item.Key} - {item.Value}");
        }
    }

    private static void MostrarLibros(List<Libro> libros)
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine(FormatearLibro(libro));
        }
    }

    private static string FormatearLibro(Libro libro)
    {
        return $"{libro.Id} - {libro.Titulo} - {libro.Precio.ToString("C")}";
    }
}