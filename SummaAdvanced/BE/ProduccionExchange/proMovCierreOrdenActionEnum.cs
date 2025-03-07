using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proMovCierreOrdenActionEnum
        {            public enum EnumproMovCierreOrdenAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproMovCierreOrdenAction(proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction.Guardar: lRetorno = "proMovCierreOrdenGuardar"; break;
                case proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction.Datos: lRetorno = "proMovCierreOrdenDevolverDatos"; break;
                case proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction.Eliminar: lRetorno = "proMovCierreOrdenEliminar"; break;
            }
            return lRetorno;
        }
    }
}
