using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRIMemoActionEnum
        {            public enum EnumcomRIMemoAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomRIMemoAction(comRIMemoActionEnum.EnumcomRIMemoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRIMemoActionEnum.EnumcomRIMemoAction.Guardar: lRetorno = "comRIMemoGuardar"; break;
                case comRIMemoActionEnum.EnumcomRIMemoAction.Eliminar: lRetorno = "comRIMemoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
