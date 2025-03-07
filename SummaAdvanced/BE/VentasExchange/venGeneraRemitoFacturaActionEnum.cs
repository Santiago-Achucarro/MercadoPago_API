using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGeneraRemitoFacturaActionEnum
        {            public enum EnumvenGeneraRemitoFacturaAction
            {
            Guardar, Datos, HacerFacturayRemito, HacerFactura, HacerRemito
        }
        public static string GetAccionvenGeneraRemitoFacturaAction(venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction.Guardar: lRetorno = "venGeneraRemitoFacturaGuardar"; break;
                case venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction.Datos: lRetorno = "venGeneraRemitoFacturaDevolverDatos"; break;
                case venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction.HacerFacturayRemito: lRetorno = "venGeneraRemitoFacturaHacerFacturayRemito"; break;
                case venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction.HacerFactura:lRetorno = "venGeneraRemitoFacturaHacerFactura";break;
                case venGeneraRemitoFacturaActionEnum.EnumvenGeneraRemitoFacturaAction.HacerRemito:lRetorno = "venGeneraRemitoFacturaHacerRemito";break;

            }
            return lRetorno;
        }
    }
}
