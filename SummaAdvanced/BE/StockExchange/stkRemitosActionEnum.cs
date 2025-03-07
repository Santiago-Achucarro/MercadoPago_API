using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 2 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkRemitosActionEnum
    {
        public enum EnumstkRemitosAction
        {
            Guardar, Eliminar, AsignarHR, DesasignarHR
        }
        public static string GetAccionstkRemitosAction(stkRemitosActionEnum.EnumstkRemitosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemitosActionEnum.EnumstkRemitosAction.Guardar: lRetorno = "stkRemitosGuardar"; break;
                case stkRemitosActionEnum.EnumstkRemitosAction.Eliminar: lRetorno = "stkRemitosEliminar"; break;
                case stkRemitosActionEnum.EnumstkRemitosAction.AsignarHR: lRetorno = "stkRemitosAsignarHR"; break;
                case stkRemitosActionEnum.EnumstkRemitosAction.DesasignarHR: lRetorno = "stkRemitosDesasignarHR"; break;
            }
            return lRetorno;
        }
    }
}
