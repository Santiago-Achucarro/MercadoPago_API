using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 3 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProvTiposActionEnum
        {            public enum EnumcomProvTiposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomProvTiposAction(comProvTiposActionEnum.EnumcomProvTiposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProvTiposActionEnum.EnumcomProvTiposAction.Guardar: lRetorno = "comProvTiposGuardar"; break;
                case comProvTiposActionEnum.EnumcomProvTiposAction.Datos: lRetorno = "comProvTiposDevolverDatos"; break;
                case comProvTiposActionEnum.EnumcomProvTiposAction.Eliminar: lRetorno = "comProvTiposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
