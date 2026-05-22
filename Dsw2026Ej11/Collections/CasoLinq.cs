using Dsw2026Ej11.Domain;
using System.Globalization;

namespace Dsw2026Ej11.Collections;

public class CasoLinq
{
    private readonly List<Libro> _libros = Libro.CrearLista();

    public Libro GetPrimero()
    {
        return _libros.First();
    }

    public Libro GetUltimo()
    {
        return _libros.Last();
    }

    public decimal GetTotalPrecios()
    {
        return _libros.Sum(l => l.Precio);
    }

    public decimal GetPromedioPrecios()
    {
        return _libros.Average(l => l.Precio);
    }

    public List<Libro> GetListById()
    {
        return _libros.Where(l => l.Id > 15).ToList();
    }

    public List<string> GetLibros()
    {
        return _libros
            .Select(l => $"{l.Titulo} - {l.Precio.ToString("C", CultureInfo.CurrentCulture)}")
            .ToList();
    }

    public Libro GetMayorPrecio()
    {
        return _libros.OrderByDescending(l => l.Precio).First();
    }

    public Libro GetMenorPrecio()
    {
        return _libros.OrderBy(l => l.Precio).First();
    }

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();

        return _libros
            .Where(l => l.Precio > promedio)
            .ToList();
    }

    public List<Libro> GetOrdenadosPorTituloDescendente()
    {
        return _libros
            .OrderByDescending(l => l.Titulo)
            .ToList();
    }
}