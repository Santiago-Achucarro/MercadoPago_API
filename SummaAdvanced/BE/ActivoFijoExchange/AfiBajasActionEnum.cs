using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 30 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiBajasActionEnum
        {            public enum EnumAfiBajasAction
            {
                Guardar,Datos,Eliminar,Calcular
            }
        public static string GetAccionAfiBajasAction(AfiBajasActionEnum.EnumAfiBajasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiBajasActionEnum.EnumAfiBajasAction.Guardar: lRetorno = "AfiBajasGuardar"; break;
                case AfiBajasActionEnum.EnumAfiBajasAction.Datos: lRetorno = "AfiBajasDevolverDatos"; break;
                case AfiBajasActionEnum.EnumAfiBajasAction.Eliminar: lRetorno = "AfiBajasEliminar"; break;
                case AfiBajasActionEnum.EnumAfiBajasAction.Calcular: lRetorno = "AfiBajasCalcular"; break;
            }
            return lRetorno;
        }
    }
}
