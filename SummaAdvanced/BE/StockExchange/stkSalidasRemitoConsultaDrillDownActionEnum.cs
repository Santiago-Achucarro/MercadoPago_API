using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de enero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkSalidasRemitoConsultaDrillDownActionEnum
        {            public enum EnumstkSalidasRemitoConsultaDrillDownAction
            {
                DatosDrillDown
            }
        public static string GetAccionstkSalidasRemitoConsultaDrillDownAction(stkSalidasRemitoConsultaDrillDownActionEnum.EnumstkSalidasRemitoConsultaDrillDownAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSalidasRemitoConsultaDrillDownActionEnum.EnumstkSalidasRemitoConsultaDrillDownAction.DatosDrillDown: lRetorno = "stkSalidasRemitoConsultaDrillDownDatosDrillDown"; break;
            }
            return lRetorno;
        }
    }
}
