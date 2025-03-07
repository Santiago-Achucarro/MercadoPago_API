using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrigenesFiscalesActionEnum
        {            public enum EnumcomOrigenesFiscalesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomOrigenesFiscalesAction(comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction.Guardar: lRetorno = "comOrigenesFiscalesGuardar"; break;
                case comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction.Datos: lRetorno = "comOrigenesFiscalesDevolverDatos"; break;
                case comOrigenesFiscalesActionEnum.EnumcomOrigenesFiscalesAction.Eliminar: lRetorno = "comOrigenesFiscalesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
