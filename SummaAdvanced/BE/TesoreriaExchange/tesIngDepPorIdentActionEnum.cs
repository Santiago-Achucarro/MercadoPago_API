using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIngDepPorIdentActionEnum
        {            public enum EnumtesIngDepPorIdentAction
            {
                Guardar,Datos,Eliminar,TotalDebe, TotalHaber, AsignarCambio, ReCalcularMonBase
        }
        public static string GetAcciontesIngDepPorIdentAction(tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.Guardar: lRetorno = "tesIngDepPorIdentGuardar"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.Datos: lRetorno = "tesIngDepPorIdentDevolverDatos"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.Eliminar: lRetorno = "tesIngDepPorIdentEliminar"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.TotalDebe: lRetorno = "tesIngDepPorIdentTotalDebe"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.TotalHaber: lRetorno = "tesIngDepPorIdentTotalHaber"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.AsignarCambio: lRetorno = "tesIngDepPorIdentAsignarCambio"; break;
                case tesIngDepPorIdentActionEnum.EnumtesIngDepPorIdentAction.ReCalcularMonBase: lRetorno = "tesIngDepPorIdentReCalcularMonBase"; break;
            }
            return lRetorno;
        }
    }
}
