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

    public bool AgregarAlumno(Alumno alumno) //ver condiciones
    {
        if (!_alumnos.ContainsKey(alumno.Id))
        {
            _alumnos.Add(alumno.Id, alumno);
            return true;
            /*Console.WriteLine($"Alumno {alumno.Id} agregado exitosamente.");}
        else
        {   Console.WriteLine($"Ya existe un alumno con legajo: {alumno.Id}");*/
        }
            return false;
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        if (_alumnos.TryGetValue(legajo, out Alumno alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        //else {Console.WriteLine($"Alumno {legajo} no encontrado.");}
        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _alumnos;
    }

    public bool EliminarAlumno(int legajo)
    {
        /*bool salida = _alumnos.Remove(legajo);

        if (salida == true)
        {
            Console.WriteLine($"Alumno {legajo} eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine($"No existe un alumno con legajo: {legajo}");
        }*/
        return _alumnos.Remove(legajo);
    }
}
