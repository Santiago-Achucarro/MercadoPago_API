using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 1 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comPagosHabilitadosActionEnum
        {            public enum EnumcomPagosHabilitadosAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomPagosHabilitadosAction(comPagosHabilitadosActionEnum.EnumcomPagosHabilitadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comPagosHabilitadosActionEnum.EnumcomPagosHabilitadosAction.Guardar: lRetorno = "comPagosHabilitadosGuardar"; break;
                case comPagosHabilitadosActionEnum.EnumcomPagosHabilitadosAction.Eliminar: lRetorno = "comPagosHabilitadosEliminar"; break;
                

            }
            return lRetorno;
        }
    }
}
