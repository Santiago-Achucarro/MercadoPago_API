using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFlujoFondoActionEnum
        {            public enum EnumtesFlujoFondoAction
            {
                Guardar,Datos,Eliminar,Calcular,TotalesLocales, GuardarParte,
                Siguente,Anterior,IrA
        }
        public static string GetAcciontesFlujoFondoAction(tesFlujoFondoActionEnum.EnumtesFlujoFondoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Guardar: lRetorno = "tesFlujoFondoGuardar"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Datos: lRetorno = "tesFlujoFondoDevolverDatos"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Eliminar: lRetorno = "tesFlujoFondoEliminar"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Calcular: lRetorno = "tesFlujoFondoCalcular"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.TotalesLocales: lRetorno = "tesFlujoFondoTotalesLocales"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.GuardarParte:lRetorno = "tesFlujoFondoGuardarParte";break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Siguente: lRetorno = "tesFlujoFondoSiguente"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.Anterior: lRetorno = "tesFlujoFondoAnterior"; break;
                case tesFlujoFondoActionEnum.EnumtesFlujoFondoAction.IrA: lRetorno = "tesFlujoFondoIrA"; break;
            }
            return lRetorno;
        }
    }
}

