using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 15 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesReversionOPActionEnum
        {            public enum EnumtesReversionOPAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber, AsignarCambio, TraeDatosMovOri
        }
        public static string GetAcciontesReversionOPAction(tesReversionOPActionEnum.EnumtesReversionOPAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesReversionOPActionEnum.EnumtesReversionOPAction.Guardar: lRetorno = "tesReversionOPGuardar"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.Datos: lRetorno = "tesReversionOPDevolverDatos"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.Eliminar: lRetorno = "tesReversionOPEliminar"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.TotalDebe: lRetorno = "tesReversionOPTotalDebe"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.TotalHaber: lRetorno = "tesReversionOPTotalHaber"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.AsignarCambio: lRetorno = "tesReversionOPAsignarCambio"; break;
                case tesReversionOPActionEnum.EnumtesReversionOPAction.TraeDatosMovOri: lRetorno = "tesReversionOPTraeDatosMovOri"; break;
            }
            return lRetorno;
        }
    }
}
