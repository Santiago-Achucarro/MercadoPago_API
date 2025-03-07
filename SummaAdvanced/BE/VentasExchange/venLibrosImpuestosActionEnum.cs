using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLibrosImpuestosActionEnum
        {            public enum EnumvenLibrosImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenLibrosImpuestosAction(venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction.Guardar: lRetorno = "venLibrosImpuestosGuardar"; break;
                case venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction.Datos: lRetorno = "venLibrosImpuestosDevolverDatos"; break;
                case venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction.Eliminar: lRetorno = "venLibrosImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
