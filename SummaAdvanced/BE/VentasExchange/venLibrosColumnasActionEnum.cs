using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLibrosColumnasActionEnum
        {            public enum EnumvenLibrosColumnasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLibrosColumnasAction(venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction.Guardar: lRetorno = "venLibrosColumnasGuardar"; break;
                case venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction.Datos: lRetorno = "venLibrosColumnasDevolverDatos"; break;
                case venLibrosColumnasActionEnum.EnumvenLibrosColumnasAction.Eliminar: lRetorno = "venLibrosColumnasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
