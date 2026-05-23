using Dsw2026Ej11.Domain;
using System.Reflection.Metadata.Ecma335;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos;

    public CasoDictionary()
    {
        _alumnos = new Dictionary<int, Alumno>(); 
    }

    public bool AgregarAlumno(Alumno alumno)
    {
        if (!_alumnos.ContainsKey(alumno.Id))
        {
            _alumnos.Add(alumno.Id, alumno);
            return true;
        }
            return false;
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (_alumnos.TryGetValue(legajo, out Alumno? alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        return null;
        //return _alumnos.GetValueOrDefault(legajo);
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _alumnos;
    }

    public bool EliminarAlumno(int legajo)
    {
        return _alumnos.Remove(legajo);
    }
}
