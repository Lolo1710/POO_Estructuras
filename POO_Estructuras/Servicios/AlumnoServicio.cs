using POO_Estructuras.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Estructuras.Servicios
{
    public class AlumnoServicio
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno alumno2 = new Alumno()
                {
                Id = 2,
                Nombre = "Alfredo",
                Apellido = "Casanova",
                Fecha = DateTime.Now,
                Grado = 3,
                Promedio = 9.5
                };
                return alumno2;
            }
            catch (Exception ex)
            {
                throw new Exception("Sucedio un error " + ex.Message);
            }
        }

        public void Imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("El nombre es: "+request.Nombre);
                Console.WriteLine("El apellido es: "+request.Apellido);
                Console.WriteLine("Ingreso: "+request.Fecha);
                Console.WriteLine("Esta en el grado: "+request.Grado);
            }
            catch(Exception ex)
            {
                throw new Exception("Sucedio un error "+ ex.Message);
            }
        }

        internal void Imprimir(object request)
        {
            throw new NotImplementedException();
        }

        #region ------Validar aprobacion
        public bool ValidarProm(double num1)
        {
            bool validar = false;
            if (num1 >= 7)
            {
                validar = true;
            }
            return validar;
        }
        #endregion
    }
}
