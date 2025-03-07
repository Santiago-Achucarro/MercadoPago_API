using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 18 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkGruposActionEnum
        {            public enum EnumstkGruposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkGruposAction(stkGruposActionEnum.EnumstkGruposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkGruposActionEnum.EnumstkGruposAction.Guardar: lRetorno = "stkGruposGuardar"; break;
                case stkGruposActionEnum.EnumstkGruposAction.Datos: lRetorno = "stkGruposDevolverDatos"; break;
                case stkGruposActionEnum.EnumstkGruposAction.Eliminar: lRetorno = "stkGruposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
