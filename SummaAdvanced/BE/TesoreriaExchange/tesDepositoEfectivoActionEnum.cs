using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de noviembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepositoEfectivoActionEnum
        {            public enum EnumtesDepositoEfectivoAction
            {
                Guardar,Datos,Eliminar,AsignarCambio,AsignarImporte
            }
        public static string GetAcciontesDepositoEfectivoAction(tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction.Guardar: lRetorno = "tesDepositoEfectivoGuardar"; break;
                case tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction.Datos: lRetorno = "tesDepositoEfectivoDevolverDatos"; break;
                case tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction.Eliminar: lRetorno = "tesDepositoEfectivoEliminar"; break;
                case tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction.AsignarCambio: lRetorno = "tesDepositoEfectivoAsignarCambio"; break;
                case tesDepositoEfectivoActionEnum.EnumtesDepositoEfectivoAction.AsignarImporte: lRetorno = "tesDepositoEfectivoAsignarImporte"; break;
            }
            return lRetorno;
        }
    }
}
