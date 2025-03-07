using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, October 25, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comCFDISatActionEnum
        {            public enum EnumcomCFDISatAction
            {
                Guardar,Datos,Eliminar, GuardarXCarpeta
        }
        public static string GetAccioncomCFDISatAction(comCFDISatActionEnum.EnumcomCFDISatAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comCFDISatActionEnum.EnumcomCFDISatAction.Guardar: lRetorno = "comCFDISatGuardar"; break;
                case comCFDISatActionEnum.EnumcomCFDISatAction.Datos: lRetorno = "comCFDISatDevolverDatos"; break;
                case comCFDISatActionEnum.EnumcomCFDISatAction.Eliminar: lRetorno = "comCFDISatEliminar"; break;
                case comCFDISatActionEnum.EnumcomCFDISatAction.GuardarXCarpeta: lRetorno = "comCFDISatGuardarXCarpeta"; break;

            }
            return lRetorno;
        }
    }
}
