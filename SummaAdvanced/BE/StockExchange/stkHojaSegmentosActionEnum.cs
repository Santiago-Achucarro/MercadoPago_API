using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 6 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkHojaSegmentosActionEnum
        {            public enum EnumstkHojaSegmentosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkHojaSegmentosAction(stkHojaSegmentosActionEnum.EnumstkHojaSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkHojaSegmentosActionEnum.EnumstkHojaSegmentosAction.Guardar: lRetorno = "stkHojaSegmentosGuardar"; break;
                case stkHojaSegmentosActionEnum.EnumstkHojaSegmentosAction.Datos: lRetorno = "stkHojaSegmentosDevolverDatos"; break;
                case stkHojaSegmentosActionEnum.EnumstkHojaSegmentosAction.Eliminar: lRetorno = "stkHojaSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
