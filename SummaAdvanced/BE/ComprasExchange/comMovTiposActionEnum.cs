using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovTiposActionEnum
        {            public enum EnumcomMovTiposAction
            {
                Datos
            }
        public static string GetAccioncomMovTiposAction(comMovTiposActionEnum.EnumcomMovTiposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovTiposActionEnum.EnumcomMovTiposAction.Datos: lRetorno = "comMovTiposDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
