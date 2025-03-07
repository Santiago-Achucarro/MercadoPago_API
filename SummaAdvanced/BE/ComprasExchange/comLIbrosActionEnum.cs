using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 31 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comLIbrosActionEnum
        {            public enum EnumcomLIbrosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomLIbrosAction(comLIbrosActionEnum.EnumcomLIbrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comLIbrosActionEnum.EnumcomLIbrosAction.Guardar: lRetorno = "comLIbrosGuardar"; break;
                case comLIbrosActionEnum.EnumcomLIbrosAction.Datos: lRetorno = "comLIbrosDevolverDatos"; break;
                case comLIbrosActionEnum.EnumcomLIbrosAction.Eliminar: lRetorno = "comLIbrosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
