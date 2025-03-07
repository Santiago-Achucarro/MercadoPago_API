using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 24 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comFactuReceStkActionEnum
    {
        public enum EnumcomFactuReceStkAction
        {
            Guardar, Eliminar, CalcularPendiente, Datos
        }
        public static string GetAccioncomFactuReceStkAction(comFactuReceStkActionEnum.EnumcomFactuReceStkAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comFactuReceStkActionEnum.EnumcomFactuReceStkAction.Datos: lRetorno = "comFactuReceStkDevolverDatos"; break;
                case comFactuReceStkActionEnum.EnumcomFactuReceStkAction.Guardar: lRetorno = "comFactuReceStkGuardar"; break;
                case comFactuReceStkActionEnum.EnumcomFactuReceStkAction.Eliminar: lRetorno = "comFactuReceStkEliminar"; break;
                case comFactuReceStkActionEnum.EnumcomFactuReceStkAction.CalcularPendiente: lRetorno = "comFactuReceStkCalcularPendiente"; break;
            }
            return lRetorno;
        }
    }
}
