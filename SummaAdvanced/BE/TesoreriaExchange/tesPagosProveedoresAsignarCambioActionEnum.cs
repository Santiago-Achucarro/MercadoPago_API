using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 26 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagosProveedoresAsignarCambioActionEnum
        {            public enum EnumtesPagosProveedoresAsignarCambioAction
            {
                AsignarCambio
            }
        public static string GetAcciontesPagosProveedoresAsignarCambioAction(tesPagosProveedoresAsignarCambioActionEnum.EnumtesPagosProveedoresAsignarCambioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosProveedoresAsignarCambioActionEnum.EnumtesPagosProveedoresAsignarCambioAction.AsignarCambio: lRetorno = "tesPagosProveedoresAsignarCambioAsignarCambio"; break;
            }
            return lRetorno;
        }
    }
}
