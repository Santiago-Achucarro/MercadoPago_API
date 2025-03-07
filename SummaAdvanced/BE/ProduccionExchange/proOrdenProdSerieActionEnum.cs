using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 20 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenProdSerieActionEnum
        {            public enum EnumproOrdenProdSerieAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenProdSerieAction(proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction.Guardar: lRetorno = "proOrdenProdSerieGuardar"; break;
                case proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction.Datos: lRetorno = "proOrdenProdSerieDevolverDatos"; break;
                case proOrdenProdSerieActionEnum.EnumproOrdenProdSerieAction.Eliminar: lRetorno = "proOrdenProdSerieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
