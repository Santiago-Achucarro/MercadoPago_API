using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 18 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkFamiliasActionEnum
        {            public enum EnumstkFamiliasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkFamiliasAction(stkFamiliasActionEnum.EnumstkFamiliasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkFamiliasActionEnum.EnumstkFamiliasAction.Guardar: lRetorno = "stkFamiliasGuardar"; break;
                case stkFamiliasActionEnum.EnumstkFamiliasAction.Datos: lRetorno = "stkFamiliasDevolverDatos"; break;
                case stkFamiliasActionEnum.EnumstkFamiliasAction.Eliminar: lRetorno = "stkFamiliasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
