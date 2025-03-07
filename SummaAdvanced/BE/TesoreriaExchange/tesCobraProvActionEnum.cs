using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 5 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCobraProvActionEnum
        {            public enum EnumtesCobraProvAction
            {
                Guardar,Datos,Eliminar,TotalDebe,TotalHaber,AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesCobraProvAction(tesCobraProvActionEnum.EnumtesCobraProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCobraProvActionEnum.EnumtesCobraProvAction.Guardar: lRetorno = "tesCobraProvGuardar"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.Datos: lRetorno = "tesCobraProvDevolverDatos"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.Eliminar: lRetorno = "tesCobraProvEliminar"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.TotalDebe: lRetorno = "tesCobraProvTotalDebe"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.TotalHaber: lRetorno = "tesCobraProvTotalHaber"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.AsignarCambio: lRetorno = "tesMovimientosDatosAsignarCambio"; break;
                case tesCobraProvActionEnum.EnumtesCobraProvAction.ReCalcularMonBase: lRetorno = "tesCobraProvReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
