using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenProdActionEnum
        {            public enum EnumproOrdenProdAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenProdAction(proOrdenProdActionEnum.EnumproOrdenProdAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenProdActionEnum.EnumproOrdenProdAction.Guardar: lRetorno = "proOrdenProdGuardar"; break;
                case proOrdenProdActionEnum.EnumproOrdenProdAction.Datos: lRetorno = "proOrdenProdDevolverDatos"; break;
                case proOrdenProdActionEnum.EnumproOrdenProdAction.Eliminar: lRetorno = "proOrdenProdEliminar"; break;
            }
            return lRetorno;
        }
    }
}
