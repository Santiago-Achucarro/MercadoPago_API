using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genPermisosActionEnum
        {            public enum EnumgenPermisosAction
            {
                Datos
            }
        public static string GetAcciongenPermisosAction(genPermisosActionEnum.EnumgenPermisosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genPermisosActionEnum.EnumgenPermisosAction.Datos: lRetorno = "genPermisosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
