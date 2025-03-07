using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLibrosActionEnum
        {            public enum EnumvenLibrosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLibrosAction(venLibrosActionEnum.EnumvenLibrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLibrosActionEnum.EnumvenLibrosAction.Guardar: lRetorno = "venLibrosGuardar"; break;
                case venLibrosActionEnum.EnumvenLibrosAction.Datos: lRetorno = "venLibrosDevolverDatos"; break;
                case venLibrosActionEnum.EnumvenLibrosAction.Eliminar: lRetorno = "venLibrosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
