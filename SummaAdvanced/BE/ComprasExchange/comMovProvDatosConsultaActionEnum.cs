using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDatosConsultaActionEnum
        {            public enum EnumcomMovProvDatosConsultaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovProvDatosConsultaAction(comMovProvDatosConsultaActionEnum.EnumcomMovProvDatosConsultaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDatosConsultaActionEnum.EnumcomMovProvDatosConsultaAction.Guardar: lRetorno = "comMovProvDatosConsultaGuardar"; break;
                case comMovProvDatosConsultaActionEnum.EnumcomMovProvDatosConsultaAction.Datos: lRetorno = "comMovProvDatosConsultaDevolverDatos"; break;
                case comMovProvDatosConsultaActionEnum.EnumcomMovProvDatosConsultaAction.Eliminar: lRetorno = "comMovProvDatosConsultaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
