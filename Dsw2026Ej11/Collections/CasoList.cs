using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoList
{
    private readonly List<Alumno> _alumnos = new List<Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<Alumno> Listar()
    {
        return _alumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void Eliminar(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumnos.Count)
        {
            _alumnos.RemoveAt(posicion);
        }
    }
}