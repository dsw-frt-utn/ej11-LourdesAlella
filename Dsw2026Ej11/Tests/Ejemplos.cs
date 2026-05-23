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
        Console.WriteLine(" === INICIO DE PRUEBA DE LISTA === ");
        CasoList pruebaList = new CasoList();
        
        Alumno alumno1 = new Alumno(57911, "Martin García", 9.5);
        Alumno alumno2 = new Alumno(58414, "Lucia Juarez", 8);
        Alumno alumno3 = new Alumno(60999, "Tomas Medina", 6.5);

        Console.WriteLine("1.Agregando alumnos...");
        pruebaList.AgregarAlumno(alumno1);
        pruebaList.AgregarAlumno(alumno2);
        pruebaList.AgregarAlumno(alumno3);

        foreach(var alumno in pruebaList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n2.Buscando alumno, nombre: Tomas Medina...");
        Alumno? encontrado1 = pruebaList.BuscarPorNombre("Tomas Medina");
        if(encontrado1 != null)
            Console.WriteLine($"Alumno encontrado: {encontrado1}");

        Console.WriteLine("\n3.Buscando alumna, nombre: Victoria Fernández...");
        Alumno? encontrado2 = pruebaList.BuscarPorNombre("Victoria Fernández");
        if (encontrado2 == null)
            Console.WriteLine($"No existe alumna");

        Console.WriteLine("\n4.Eliminando alumno...");
        pruebaList.EliminarAlumno(alumno2);
        foreach (var alumno in pruebaList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n5.Eliminando primer alumno de lista...");
        pruebaList.EliminarPorPosicion(0);
        foreach (var alumno in pruebaList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }
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
            Console.WriteLine($"Alumno encontrado: {encontrado1}");

        Console.WriteLine("\n3.Buscando alumno 59788...");
        Alumno? encontrado2 = pruebaDictionary.BuscarAlumno(59788);
        if (encontrado2 == null)
            Console.WriteLine($"No existe alumno");

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
        Console.WriteLine(" === INICIO DE PRUEBA DE LINQ === ");
        CasoLinq pruebaLinq = new CasoLinq();

        Console.WriteLine($"1.Primer libro: ");
        Libro? primero = pruebaLinq.GetPrimero();
        if (primero != null)
            Console.WriteLine($"{primero.Id} - {primero.Titulo} - {primero.Precio:C}");
        else
            Console.WriteLine("No hay libros disponibles");

        Console.WriteLine("\n2.Ultimo libro: ");
        Libro? ultimo = pruebaLinq.GetUltimo();
        if (ultimo != null)
            Console.WriteLine($"{ultimo.Id} - {ultimo.Titulo} - {ultimo.Precio:C}");

        Console.WriteLine($"\n3.Suma de precios de libros: {pruebaLinq.GetTotalPrecios():C}");

        Console.WriteLine($"\n4.Promedio de precios de libros: {pruebaLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\n5.Lista de libros con Id mayor a 15: ");
        foreach (var libro in pruebaLinq.GetListById())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\n6.Lista de cada libro:");
        foreach (string libro in pruebaLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n7.libro con el precio más alto: ");
        Libro? mayor = pruebaLinq.GetMayorPrecio();
        if (mayor != null)
            Console.WriteLine($"{mayor.Id} - {mayor.Titulo} - {mayor.Precio:C}");

        Console.WriteLine("\n8.libro con el precio más bajo: ");
        Libro? menor = pruebaLinq.GetMenorPrecio();
        if (menor != null)
            Console.WriteLine($"{menor.Id} - {menor.Titulo} - {menor.Precio:C}");

        Console.WriteLine("\n9.libros con precio sea mayor al promedio:");
        foreach (var libro in pruebaLinq.GetMayorPromedio())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine("\n10.libros ordenados por título de forma descendente:");
        foreach (var libro in pruebaLinq.ListaDesendenteLibros())
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }
    }
}
