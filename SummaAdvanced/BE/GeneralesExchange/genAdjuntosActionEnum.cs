using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 20 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAdjuntosActionEnum
        {            public enum EnumgenAdjuntosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenAdjuntosAction(genAdjuntosActionEnum.EnumgenAdjuntosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAdjuntosActionEnum.EnumgenAdjuntosAction.Guardar: lRetorno = "genAdjuntosGuardar"; break;
                case genAdjuntosActionEnum.EnumgenAdjuntosAction.Datos: lRetorno = "genAdjuntosDevolverDatos"; break;
                case genAdjuntosActionEnum.EnumgenAdjuntosAction.Eliminar: lRetorno = "genAdjuntosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
