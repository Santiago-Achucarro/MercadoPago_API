using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiFijoCerrarActionEnum
        {            public enum EnumAfiFijoCerrarAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionAfiFijoCerrarAction(AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction.Guardar: lRetorno = "AfiFijoCerrarGuardar"; break;
                case AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction.Datos: lRetorno = "AfiFijoCerrarDevolverDatos"; break;
                case AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction.Eliminar: lRetorno = "AfiFijoCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
