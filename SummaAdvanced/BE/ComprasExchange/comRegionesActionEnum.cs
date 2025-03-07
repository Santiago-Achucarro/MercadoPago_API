using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRegionesActionEnum
        {            public enum EnumcomRegionesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomRegionesAction(comRegionesActionEnum.EnumcomRegionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRegionesActionEnum.EnumcomRegionesAction.Guardar: lRetorno = "comRegionesGuardar"; break;
                case comRegionesActionEnum.EnumcomRegionesAction.Datos: lRetorno = "comRegionesDevolverDatos"; break;
                case comRegionesActionEnum.EnumcomRegionesAction.Eliminar: lRetorno = "comRegionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
