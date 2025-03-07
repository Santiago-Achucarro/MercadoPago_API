using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProvAnexoActionEnum
        {            public enum EnumcomProvAnexoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomProvAnexoAction(comProvAnexoActionEnum.EnumcomProvAnexoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProvAnexoActionEnum.EnumcomProvAnexoAction.Guardar: lRetorno = "comProvAnexoGuardar"; break;
                case comProvAnexoActionEnum.EnumcomProvAnexoAction.Datos: lRetorno = "comProvAnexoDevolverDatos"; break;
                case comProvAnexoActionEnum.EnumcomProvAnexoAction.Eliminar: lRetorno = "comProvAnexoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
