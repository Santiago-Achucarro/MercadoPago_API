using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proTrabajo3ProvActionEnum
        {            public enum EnumproTrabajo3ProvAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproTrabajo3ProvAction(proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction.Guardar: lRetorno = "proTrabajo3ProvGuardar"; break;
                case proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction.Datos: lRetorno = "proTrabajo3ProvDevolverDatos"; break;
                case proTrabajo3ProvActionEnum.EnumproTrabajo3ProvAction.Eliminar: lRetorno = "proTrabajo3ProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
