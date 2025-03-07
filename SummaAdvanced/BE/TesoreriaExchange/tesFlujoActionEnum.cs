using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesFlujoActionEnum
    {
        public enum EnumtesFlujoAction
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAcciontesFlujoAction(tesFlujoActionEnum.EnumtesFlujoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFlujoActionEnum.EnumtesFlujoAction.Guardar: lRetorno = "tesFlujoGuardar"; break;
                case tesFlujoActionEnum.EnumtesFlujoAction.Datos: lRetorno = "tesFlujoDevolverDatos"; break;
                case tesFlujoActionEnum.EnumtesFlujoAction.Eliminar: lRetorno = "tesFlujoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
