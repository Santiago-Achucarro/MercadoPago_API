using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 30 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impCfdiMetaActionEnum
        {            public enum EnumimpCfdiMetaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpCfdiMetaAction(impCfdiMetaActionEnum.EnumimpCfdiMetaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impCfdiMetaActionEnum.EnumimpCfdiMetaAction.Guardar: lRetorno = "impCfdiMetaGuardar"; break;
                case impCfdiMetaActionEnum.EnumimpCfdiMetaAction.Datos: lRetorno = "impCfdiMetaDevolverDatos"; break;
                case impCfdiMetaActionEnum.EnumimpCfdiMetaAction.Eliminar: lRetorno = "impCfdiMetaEliminar"; break;
                
            }
            return lRetorno;
        }
    }
}
