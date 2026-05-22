using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarPorClave(int legajo)
    {
        if (_alumnos.ContainsKey(legajo))
        {
            return _alumnos[legajo];
        }

        return null;
    }

    public Dictionary<int, Alumno> Listar()
    {
        return _alumnos;
    }

    public void Eliminar(int legajo)
    {
        _alumnos.Remove(legajo);
    }
}