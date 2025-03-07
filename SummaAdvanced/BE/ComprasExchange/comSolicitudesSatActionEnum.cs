using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 24 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comSolicitudesSatActionEnum
        {            public enum EnumcomSolicitudesSatAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomSolicitudesSatAction(comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction.Guardar: lRetorno = "comSolicitudesSatGuardar"; break;
                case comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction.Datos: lRetorno = "comSolicitudesSatDevolverDatos"; break;
                case comSolicitudesSatActionEnum.EnumcomSolicitudesSatAction.Eliminar: lRetorno = "comSolicitudesSatEliminar"; break;
            }
            return lRetorno;
        }
    }
}
