using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, August 24, 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comCFDISatDatosRangoActionEnum
        {            public enum EnumcomCFDISatDatosRangoAction
            {
                Datos,Eliminar, MarcaTodas
        }
        public static string GetAccioncomCFDISatDatosRangoAction(comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction.Datos: lRetorno = "comCFDISatDatosRangoDevolverDatos"; break;
                case comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction.Eliminar: lRetorno = "comCFDISatDatosRangoEliminar"; break;
                case comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction.MarcaTodas: lRetorno = "comCFDISatDatosRangoMarcaTodas"; break;
            }
            return lRetorno;
        }
    }
}
