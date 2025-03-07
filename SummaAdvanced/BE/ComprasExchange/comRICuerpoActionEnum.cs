using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRICuerpoActionEnum
        {            public enum EnumcomRICuerpoAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomRICuerpoAction(comRICuerpoActionEnum.EnumcomRICuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRICuerpoActionEnum.EnumcomRICuerpoAction.Guardar: lRetorno = "comRICuerpoGuardar"; break;
                case comRICuerpoActionEnum.EnumcomRICuerpoAction.Eliminar: lRetorno = "comRICuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
