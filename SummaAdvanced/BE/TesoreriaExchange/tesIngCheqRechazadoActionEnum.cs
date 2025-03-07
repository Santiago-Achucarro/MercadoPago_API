using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 13 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIngCheqRechazadoActionEnum
        {            public enum EnumtesIngCheqRechazadoAction
            {
                Guardar,Datos,Eliminar,TotalDebe, TotalHaber, TraerCheques, CalcularHaber,AsignarCambio,ReCalcularMonBase
        }
        public static string GetAcciontesIngCheqRechazadoAction(tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.Guardar:
                    lRetorno = "tesIngCheqRechazadoGuardar"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.Datos:
                    lRetorno = "tesIngCheqRechazadoDevolverDatos"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.Eliminar:
                    lRetorno = "tesIngCheqRechazadoEliminar"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.TotalDebe:
                    lRetorno = "tesIngCheqRechazadoTotalDebe"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.TotalHaber:
                    lRetorno = "tesIngCheqRechazadoTotalHaber"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.TraerCheques:
                    lRetorno = "tesIngCheqRechazadoTraerCheques"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.CalcularHaber:
                    lRetorno = "tesIngCheqRechazadoCalcularHaber"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.AsignarCambio:
                    lRetorno = "tesIngCheqRechazadoAsignarCambio"; break;
                case tesIngCheqRechazadoActionEnum.EnumtesIngCheqRechazadoAction.ReCalcularMonBase:
                    lRetorno = "tesIngCheqRechazadoReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
