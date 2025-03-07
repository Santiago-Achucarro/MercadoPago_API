using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvRemiPendDatosRemiActionEnum
        {            public enum EnumcomMovProvRemiPendDatosRemiAction
            {
                Datos
            }
        public static string GetAccioncomMovProvRemiPendDatosRemiAction(comMovProvRemiPendDatosRemiActionEnum.EnumcomMovProvRemiPendDatosRemiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvRemiPendDatosRemiActionEnum.EnumcomMovProvRemiPendDatosRemiAction.Datos: lRetorno = "comMovProvRemiPendDatosRemiDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
