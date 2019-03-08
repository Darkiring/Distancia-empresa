using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeEmpresa
{
    //Datos de la persona, aqui sucede lo mismo que en las variables de la clase Empresas, una clase static, para utilizar las variables
    public static class DireccionPersona
    {
        /*El public static, es utilizado para que las variables
         puedan ser utilizadas en la clase Program donde se calcula */
        public static string Nombre = "Victoria";
        public static string FechaNacimiento = "9/11/1986";
        public static int CoordY = 2;
        public static int CoordX = 3;
        public static int cedula = 1019083225;
        
    }
}
