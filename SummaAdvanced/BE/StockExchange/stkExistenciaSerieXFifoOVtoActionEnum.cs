using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 14 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkExistenciaSerieXFifoOVtoActionEnum
        {            public enum EnumstkExistenciaSerieXFifoOVtoAction
            {
                Datos
            }
        public static string GetAccionstkExistenciaSerieXFifoOVtoAction(stkExistenciaSerieXFifoOVtoActionEnum.EnumstkExistenciaSerieXFifoOVtoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkExistenciaSerieXFifoOVtoActionEnum.EnumstkExistenciaSerieXFifoOVtoAction.Datos: lRetorno = "stkExistenciaSerieXFifoOVtoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
