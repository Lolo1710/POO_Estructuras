using POO_Estructuras.Servicios;
using System;

namespace POO_Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlumnoServicio alumnoservicio = new AlumnoServicio();

            var res = alumnoservicio.Agregar();
            alumnoservicio.Imprimir(res);
            Console.WriteLine("La calificacion es "+ alumnoservicio.ValidarProm(res.Promedio);
        }
    }
}
