using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEmbarquesActionEnum
        {            public enum EnumcomEmbarquesAction
            {
                Guardar,Datos,Eliminar,CalcularPreciosEstimados,AgregarOC, CalcularTotal, Todas, Ninguna
        }
        public static string GetAccioncomEmbarquesAction(comEmbarquesActionEnum.EnumcomEmbarquesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.Guardar: lRetorno = "comEmbarquesGuardar"; break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.Datos: lRetorno = "comEmbarquesDevolverDatos"; break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.Eliminar: lRetorno = "comEmbarquesEliminar"; break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.CalcularPreciosEstimados: lRetorno = "comEmbarquesCalcularPreciosEstimados"; break;
                case EnumcomEmbarquesAction.AgregarOC: lRetorno = "comEmbarquesAgregarOC";break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.CalcularTotal: lRetorno = "comEmbarquesCalcularTotal"; break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.Todas: lRetorno = "comEmbarquesTodas"; break;
                case comEmbarquesActionEnum.EnumcomEmbarquesAction.Ninguna: lRetorno = "comEmbarquesNinguna"; break;
            }
            return lRetorno;
        }
    }
}
