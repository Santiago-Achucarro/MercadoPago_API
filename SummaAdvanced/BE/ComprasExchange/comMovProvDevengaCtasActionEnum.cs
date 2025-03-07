using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de abril de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDevengaCtasActionEnum
        {            public enum EnumcomMovProvDevengaCtasAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomMovProvDevengaCtasAction(comMovProvDevengaCtasActionEnum.EnumcomMovProvDevengaCtasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDevengaCtasActionEnum.EnumcomMovProvDevengaCtasAction.Guardar: lRetorno = "comMovProvDevengaCtasGuardar"; break;
                case comMovProvDevengaCtasActionEnum.EnumcomMovProvDevengaCtasAction.Eliminar: lRetorno = "comMovProvDevengaCtasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
