using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de noviembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepositosChequesActionEnum
        {            public enum EnumtesDepositosChequesAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber, AsignarCambio, TraeChequesCartera,MarcarTodos,DesMarcarTodos, ReCalcularMonBase
        }
        public static string GetAcciontesDepositosChequesAction(tesDepositosChequesActionEnum.EnumtesDepositosChequesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.Guardar:
                    lRetorno = "tesDepositosChequesGuardar"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.Datos:
                    lRetorno = "tesDepositosChequesDevolverDatos"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.Eliminar:
                    lRetorno = "tesDepositosChequesEliminar"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.TotalDebe:
                    lRetorno = "tesDepositosChequesTotalDebe"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.TotalHaber:
                    lRetorno = "tesDepositosChequesTotalHaber"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.AsignarCambio:
                    lRetorno = "tesDepositosChequesAsignarCambio"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.TraeChequesCartera:
                    lRetorno = "tesDepositosChequesTraeChequesCartera"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.MarcarTodos:
                    lRetorno = "tesDepositosChequesMarcarTodos"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.DesMarcarTodos:
                    lRetorno = "tesDepositosChequesDesMarcarTodos"; break;
                case tesDepositosChequesActionEnum.EnumtesDepositosChequesAction.ReCalcularMonBase:
                    lRetorno = "tesDepositosChequesReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
