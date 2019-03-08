using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeEmpresa
{
    class Empresas
    {
        //Datos de la primera empresa, es una clase publica para poder ser llamada y utilizar las variables asignada a esta
        public static class EmpresaNumero1
        {
            /*El public static, es utilizado para que las variables
              puedan ser utilizadas en la clase Program donde se calcula */
            public static int Nit1 = 85463;
            public static string Nombre1 = "Empresa Ramirez";
            public static string Direccion1 = "Calle Primera, #4";
            public static string Telefono1 = "8547";
            public static int CoordY1 = 6;
            public static int CoordX1 = 4;

        }

        //Datos de la segunda empresa, Esta de igual manera que la primera clase
        public static class EmpresaNumero2
        {
            //Esta codificado de igual forma que la primera empresa
            public static int Nit = 34526;
            public static string Nombre2 = "Empresa Esperanza";
            public static string Direccion2 = "Calle 27, #6";
            public static string Telefono2 = "56321";
            public static int CoordY2 = 5;
            public static int CoordX2 = 3;

        }
    }
}
