using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class provarGlobalesActionEnum
        {            public enum EnumprovarGlobalesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionprovarGlobalesAction(provarGlobalesActionEnum.EnumprovarGlobalesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case provarGlobalesActionEnum.EnumprovarGlobalesAction.Guardar: lRetorno = "provarGlobalesGuardar"; break;
                case provarGlobalesActionEnum.EnumprovarGlobalesAction.Datos: lRetorno = "provarGlobalesDevolverDatos"; break;
                case provarGlobalesActionEnum.EnumprovarGlobalesAction.Eliminar: lRetorno = "provarGlobalesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
