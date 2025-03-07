using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 16 de febrero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genTareasProgramadasActionEnum
        {            public enum EnumgenTareasProgramadasAction
            {
                Guardar,Datos,Eliminar,ParametrosTarea,Ejecutar
            }
        public static string GetAcciongenTareasProgramadasAction(genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.Guardar: lRetorno = "genTareasProgramadasGuardar"; break;
                case genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.Datos: lRetorno = "genTareasProgramadasDevolverDatos"; break;
                case genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.Eliminar: lRetorno = "genTareasProgramadasEliminar"; break;
                case genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.ParametrosTarea: lRetorno = "genTareasProgramadasParametrosTarea"; break;
                case genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.Ejecutar: lRetorno = "genTareasProgramadasEjecutar"; break;
            }
            return lRetorno;
        }
    }
}
