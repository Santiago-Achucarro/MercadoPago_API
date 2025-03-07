using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 30 de abril de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRepartoRemitosActionEnum
        {            public enum EnumvenRepartoRemitosAction
            {
                Datos
            }
        public static string GetAccionvenRepartoRemitosAction(venRepartoRemitosActionEnum.EnumvenRepartoRemitosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepartoRemitosActionEnum.EnumvenRepartoRemitosAction.Datos: lRetorno = "venRepartoRemitosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
