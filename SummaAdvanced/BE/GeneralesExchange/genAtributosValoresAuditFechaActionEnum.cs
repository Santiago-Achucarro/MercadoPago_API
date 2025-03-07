using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 23 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genAtributosValoresAuditFechaActionEnum
    {
        public enum EnumgenAtributosValoresAuditFechaAction
        {
            Datos
        }
        public static string GetAcciongenAtributosValoresAuditFechaAction(genAtributosValoresAuditFechaActionEnum.EnumgenAtributosValoresAuditFechaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtributosValoresAuditFechaActionEnum.EnumgenAtributosValoresAuditFechaAction.Datos:
                    lRetorno = "genAtributosValoresAuditFechaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
