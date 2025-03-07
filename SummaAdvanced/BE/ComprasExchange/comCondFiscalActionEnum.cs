using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comCondFiscalActionEnum
        {            public enum EnumcomCondFiscalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomCondFiscalAction(comCondFiscalActionEnum.EnumcomCondFiscalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comCondFiscalActionEnum.EnumcomCondFiscalAction.Guardar: lRetorno = "comCondFiscalGuardar"; break;
                case comCondFiscalActionEnum.EnumcomCondFiscalAction.Datos: lRetorno = "comCondFiscalDevolverDatos"; break;
                case comCondFiscalActionEnum.EnumcomCondFiscalAction.Eliminar: lRetorno = "comCondFiscalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
