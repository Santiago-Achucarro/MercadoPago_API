using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 4 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAsiCierreCalculoActionEnum
        {            public enum EnumcomAsiCierreCalculoAction
            {
                Datos
            }
        public static string GetAccioncomAsiCierreCalculoAction(comAsiCierreCalculoActionEnum.EnumcomAsiCierreCalculoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAsiCierreCalculoActionEnum.EnumcomAsiCierreCalculoAction.Datos: lRetorno = "comAsiCierreCalculoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
