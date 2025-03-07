using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de abril de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDevengaContActionEnum
        {            public enum EnumcomMovProvDevengaContAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomMovProvDevengaContAction(comMovProvDevengaContActionEnum.EnumcomMovProvDevengaContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDevengaContActionEnum.EnumcomMovProvDevengaContAction.Guardar: lRetorno = "comMovProvDevengaContGuardar"; break;
                case comMovProvDevengaContActionEnum.EnumcomMovProvDevengaContAction.Eliminar: lRetorno = "comMovProvDevengaContEliminar"; break;
            }
            return lRetorno;
        }
    }
}
