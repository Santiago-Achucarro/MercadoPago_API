using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRISegmentoActionEnum
        {            public enum EnumcomRISegmentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomRISegmentoAction(comRISegmentoActionEnum.EnumcomRISegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRISegmentoActionEnum.EnumcomRISegmentoAction.Guardar: lRetorno = "comRISegmentoGuardar"; break;
                case comRISegmentoActionEnum.EnumcomRISegmentoAction.Datos: lRetorno = "comRISegmentoDevolverDatos"; break;
                case comRISegmentoActionEnum.EnumcomRISegmentoAction.Eliminar: lRetorno = "comRISegmentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
