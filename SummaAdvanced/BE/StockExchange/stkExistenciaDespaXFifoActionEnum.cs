using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaDespaXFifoActionEnum
        {            public enum EnumstkExistenciaDespaXFifoAction
            {
                Datos
            }
        public static string GetAccionstkExistenciaDespaXFifoAction(stkExistenciaDespaXFifoActionEnum.EnumstkExistenciaDespaXFifoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaDespaXFifoActionEnum.EnumstkExistenciaDespaXFifoAction.Datos: lRetorno = "stkExistenciaDespaXFifoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
