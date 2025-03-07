using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 6, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comNivelesAutoActionEnum
        {            public enum EnumcomNivelesAutoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomNivelesAutoAction(comNivelesAutoActionEnum.EnumcomNivelesAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comNivelesAutoActionEnum.EnumcomNivelesAutoAction.Guardar: lRetorno = "comNivelesAutoGuardar"; break;
                case comNivelesAutoActionEnum.EnumcomNivelesAutoAction.Datos: lRetorno = "comNivelesAutoDevolverDatos"; break;
                case comNivelesAutoActionEnum.EnumcomNivelesAutoAction.Eliminar: lRetorno = "comNivelesAutoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
