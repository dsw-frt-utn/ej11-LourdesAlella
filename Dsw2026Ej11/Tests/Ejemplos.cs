using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        Console.WriteLine(" === INICIO DE PRUEBA DE DICCIONARIO === ");
        CasoDictionary pruebaDictionary = new CasoDictionary();

        Console.WriteLine("1.Agregando alumnos...");
        Alumno alumno1 = new Alumno(57911, "Martin García", 9.5);
        Alumno alumno2 = new Alumno(58414, "Lucia Juarez", 8);
        Alumno alumno3 = new Alumno(60999, "Tomas Medina", 6.5);

        pruebaDictionary.AgregarAlumno(alumno1);
        pruebaDictionary.AgregarAlumno(alumno2);
        pruebaDictionary.AgregarAlumno(alumno3);

        var listaAlumnos = pruebaDictionary.RetornarDiccionario();

        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine(alumno.Value);
        }

        Console.WriteLine("\n2.Buscando alumno 57911...");
        Alumno? encontrado1 = pruebaDictionary.BuscarAlumno(57911);

        if (encontrado1 != null)
        {
            Console.WriteLine($"Alumno encontrado: {encontrado1}");
        }

        Console.WriteLine("\n3.Buscando alumno 59788...");
        Alumno? encontrado2 = pruebaDictionary.BuscarAlumno(59788);
        if (encontrado2 == null)
        {
            Console.WriteLine($"No existe alumno");
        }

        Console.WriteLine("\n4.Eliminando alumno 57911...");
        pruebaDictionary.EliminarAlumno(57911);

        foreach (var alumno in listaAlumnos)
        {
            Console.WriteLine(alumno.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
