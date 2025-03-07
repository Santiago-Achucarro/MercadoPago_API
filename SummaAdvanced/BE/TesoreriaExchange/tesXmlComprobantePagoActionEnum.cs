using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesXmlComprobantePagoActionEnum
        {            public enum EnumtesXmlComprobantePagoAction
            {
                Datos
            }
        public static string GetAcciontesXmlComprobantePagoAction(tesXmlComprobantePagoActionEnum.EnumtesXmlComprobantePagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesXmlComprobantePagoActionEnum.EnumtesXmlComprobantePagoAction.Datos: lRetorno = "tesXmlComprobantePagoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
