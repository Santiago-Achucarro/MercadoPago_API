using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRIArticuloActionEnum
        {            public enum EnumcomRIArticuloAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomRIArticuloAction(comRIArticuloActionEnum.EnumcomRIArticuloAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRIArticuloActionEnum.EnumcomRIArticuloAction.Guardar: lRetorno = "comRIArticuloGuardar"; break;
                case comRIArticuloActionEnum.EnumcomRIArticuloAction.Eliminar: lRetorno = "comRIArticuloEliminar"; break;
            }
            return lRetorno;
        }
    }
}
