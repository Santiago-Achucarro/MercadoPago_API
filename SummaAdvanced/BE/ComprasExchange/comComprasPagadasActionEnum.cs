using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 25 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comComprasPagadasActionEnum
        {            public enum EnumcomComprasPagadasAction
            {
                Guardar,Datos
            }
        public static string GetAccioncomComprasPagadasAction(comComprasPagadasActionEnum.EnumcomComprasPagadasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comComprasPagadasActionEnum.EnumcomComprasPagadasAction.Guardar: lRetorno = "comComprasPagadasGuardar"; break;
                case comComprasPagadasActionEnum.EnumcomComprasPagadasAction.Datos: lRetorno = "comComprasPagadasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
