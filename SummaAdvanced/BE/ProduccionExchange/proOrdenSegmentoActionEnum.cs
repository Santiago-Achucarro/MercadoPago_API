using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenSegmentoActionEnum
        {            public enum EnumproOrdenSegmentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenSegmentoAction(proOrdenSegmentoActionEnum.EnumproOrdenSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenSegmentoActionEnum.EnumproOrdenSegmentoAction.Guardar: lRetorno = "proOrdenSegmentoGuardar"; break;
                case proOrdenSegmentoActionEnum.EnumproOrdenSegmentoAction.Datos: lRetorno = "proOrdenSegmentoDevolverDatos"; break;
                case proOrdenSegmentoActionEnum.EnumproOrdenSegmentoAction.Eliminar: lRetorno = "proOrdenSegmentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
