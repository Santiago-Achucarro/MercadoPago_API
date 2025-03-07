using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comListaNegraMXActionEnum
        {            public enum EnumcomListaNegraMXAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomListaNegraMXAction(comListaNegraMXActionEnum.EnumcomListaNegraMXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comListaNegraMXActionEnum.EnumcomListaNegraMXAction.Guardar: lRetorno = "comListaNegraMXGuardar"; break;
                case comListaNegraMXActionEnum.EnumcomListaNegraMXAction.Datos: lRetorno = "comListaNegraMXDevolverDatos"; break;
                case comListaNegraMXActionEnum.EnumcomListaNegraMXAction.Eliminar: lRetorno = "comListaNegraMXEliminar"; break;
            }
            return lRetorno;
        }
    }
}
