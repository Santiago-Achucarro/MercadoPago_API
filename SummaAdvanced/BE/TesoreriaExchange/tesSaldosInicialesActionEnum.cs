using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 29 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSaldosInicialesActionEnum
        {            public enum EnumtesSaldosInicialesAction
            {
            Guardar, Datos, Eliminar, TotalDebe, TotalHaber, AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesSaldosInicialesAction(tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.Guardar:
                    lRetorno = "tesSaldosInicialesGuardar"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.Datos:
                    lRetorno = "tesSaldosInicialesDevolverDatos"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.Eliminar:
                    lRetorno = "tesSaldosInicialesEliminar"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.TotalDebe:
                    lRetorno = "tesSaldosInicialesTotalDebe"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.TotalHaber:
                    lRetorno = "tesSaldosInicialesTotalHaber"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.AsignarCambio:
                    lRetorno = "tesSaldosInicialesAsignarCambio"; break;
                case tesSaldosInicialesActionEnum.EnumtesSaldosInicialesAction.ReCalcularMonBase:
                    lRetorno = "tesSaldosInicialesReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
