using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTareasActionEnum
        {            public enum EnumsueTareasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTareasAction(sueTareasActionEnum.EnumsueTareasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTareasActionEnum.EnumsueTareasAction.Guardar: lRetorno = "sueTareasGuardar"; break;
                case sueTareasActionEnum.EnumsueTareasAction.Datos: lRetorno = "sueTareasDevolverDatos"; break;
                case sueTareasActionEnum.EnumsueTareasAction.Eliminar: lRetorno = "sueTareasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
