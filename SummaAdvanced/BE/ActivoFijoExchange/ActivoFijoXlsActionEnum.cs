using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 12 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class ActivoFijoXlsActionEnum
        {            public enum EnumActivoFijoXlsAction
            {
                Guardar,Validar
            }
        public static string GetAccionActivoFijoXlsAction(ActivoFijoXlsActionEnum.EnumActivoFijoXlsAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ActivoFijoXlsActionEnum.EnumActivoFijoXlsAction.Guardar: lRetorno = "ActivoFijoXlsGuardar"; break;
                case ActivoFijoXlsActionEnum.EnumActivoFijoXlsAction.Validar: lRetorno = "ActivoFijoXlsValidar"; break;
            }
            return lRetorno;
        }
    }
}
