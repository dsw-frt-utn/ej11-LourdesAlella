using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _listaAlumnos;

    public CasoList()
    {
        _listaAlumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        _listaAlumnos.Add(alumno);
    }

    public List<Alumno> RetornarLista()
    {
        return _listaAlumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        int indice = _listaAlumnos.FindIndex(a => a.Nombre.Equals(nombre));
        if(indice != -1)
        {
            return _listaAlumnos[indice];
        }
        return null;
    }

    public bool EliminarAlumno(Alumno alumno)
    {
        return _listaAlumnos.Remove(alumno);
    }

    public bool EliminarPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _listaAlumnos.Count)
        {
            _listaAlumnos.RemoveAt(posicion);
            return true;
        }
        return false;
    }
}
