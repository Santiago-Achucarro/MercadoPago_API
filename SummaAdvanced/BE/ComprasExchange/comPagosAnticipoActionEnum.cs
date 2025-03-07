using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 1 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comPagosAnticipoActionEnum
        {            public enum EnumcomPagosAnticipoAction
            {
                Guardar,Eliminar,MarcarPagado
        }
        public static string GetAccioncomPagosAnticipoAction(comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction.Guardar: lRetorno = "comPagosAnticipoGuardar"; break;
                case comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction.Eliminar: lRetorno = "comPagosAnticipoEliminar"; break;
                case comPagosAnticipoActionEnum.EnumcomPagosAnticipoAction.MarcarPagado: lRetorno = "comPagosAnticipoMarcarPagado"; break;
            }
            return lRetorno;
        }
    }
}
