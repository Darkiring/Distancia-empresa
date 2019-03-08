using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeEmpresa
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Determinando la distancia mas cercana, y es determinado por el calculo realizado en las dos clases donde calculamos cada empresa
            //La empresa con el resultado menor es mostrado en el resultado, junto con los datos de la persona
            //Si la primera empresa es menor, el resultado es mostrado, de lo contrario el segundo es mostrado
            if (CalculoDeLaPrimeraDistancia.Distancia1 <= CalculoDeLaSegundaDistancia.Distancia2)
            {
                Console.WriteLine("La Distancia mas cercana es de la Empresa: " + Empresas.EmpresaNumero1.Nombre1);
                Console.WriteLine("Direccion: " + Empresas.EmpresaNumero1.Direccion1);
                Console.WriteLine("Telefono: " + Empresas.EmpresaNumero1.Telefono1);
                Console.WriteLine("Datos Persona: ");
                Console.WriteLine("Nombre: " + DireccionPersona.Nombre);
                Console.WriteLine("Fecha de Nacimiento: " + DireccionPersona.FechaNacimiento);
                Console.WriteLine("Cedula: " + DireccionPersona.cedula);
            }
                //Si el primer caso no se cumple, se pasa a mostrar la segunda empresa
                else
                {
                Console.WriteLine("La Distancia mas cercana es de la Empresa: " + Empresas.EmpresaNumero2.Nombre2);
                Console.WriteLine("Direccion: " + Empresas.EmpresaNumero2.Direccion2);
                Console.WriteLine("Telefono: " + Empresas.EmpresaNumero2.Telefono2);
                Console.WriteLine("Datos Persona: ");
                Console.WriteLine("Nombre: " + DireccionPersona.Nombre);
                Console.WriteLine("Fecha de Nacimiento: " + DireccionPersona.FechaNacimiento);
                Console.WriteLine("Cedula: " + DireccionPersona.cedula);
            }

            //Es utilizado para hacer pausa en pantalla
            Console.ReadLine();
        }

        //Aqui se realiza el calculo de las distancias de las empresas y la persona
        public static class CalculoDeLaPrimeraDistancia
        {
            //Se llaman las variables desde la clase donde estan declaradas, y les son asignadas a las nuevas variables para hacer los calculos
            //Tambien deben ser staticas, ya que debemos usar el calculo final para determinar la menor distancia
            public static int PersX1 = DireccionPersona.CoordX;
            public static int EmX1 = Empresas.EmpresaNumero1.CoordX1;
            public static int EmpY2 = Empresas.EmpresaNumero1.CoordY1;
            public static int PersY1 = DireccionPersona.CoordY;

            public static double Distancia1 = Math.Sqrt(Math.Pow((EmX1 - PersX1), 2) + Math.Pow((EmpY2 - PersY1), 2));        

        }


        public static class CalculoDeLaSegundaDistancia
        {
            //Sucede lo mismo que en la anterior clase
            //Se llaman las variables desde la clase donde estan declaradas, y les son asignadas a las nuevas variables para hacer los calculos
            //Tambien deben ser staticas, ya que debemos usar el calculo final para determinar la menor distancia
            public static int PersX1 = DireccionPersona.CoordX;
            public static int EmX1 = Empresas.EmpresaNumero2.CoordX2;
            public static int EmpY2 = Empresas.EmpresaNumero2.CoordY2;
            public static int PersY1 = DireccionPersona.CoordY;

            public static double Distancia2 = Math.Sqrt(Math.Pow((EmX1 - PersX1), 2) + Math.Pow((EmpY2 - PersY1), 2));

        }
    }
}
