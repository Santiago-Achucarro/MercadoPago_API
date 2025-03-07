using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, October 24, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comCFDISatPagoActionEnum
        {            public enum EnumcomCFDISatPagoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomCFDISatPagoAction(comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction.Guardar: lRetorno = "comCFDISatPagoGuardar"; break;
                case comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction.Datos: lRetorno = "comCFDISatPagoDevolverDatos"; break;
                case comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction.Eliminar: lRetorno = "comCFDISatPagoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
