using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conPeriodosActionEnum
        {            public enum EnumconPeriodosAction
            {
                Guardar,Datos,Eliminar,DatosPorFecha,CambiarEstado

        }
        public static string GetAccionconPeriodosAction(conPeriodosActionEnum.EnumconPeriodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case EnumconPeriodosAction.Guardar: lRetorno = "conPeriodosGuardar"; break;
                case EnumconPeriodosAction.Datos: lRetorno = "conPeriodosDevolverDatos"; break;
                case EnumconPeriodosAction.Eliminar: lRetorno = "conPeriodosEliminar"; break;
                case EnumconPeriodosAction.DatosPorFecha: lRetorno = "conPeriodosDatosPorFecha";break;
                case EnumconPeriodosAction.CambiarEstado: lRetorno = "conPeriodosCambiarEstado"; break;
            }
            return lRetorno;
        }
    }
}
