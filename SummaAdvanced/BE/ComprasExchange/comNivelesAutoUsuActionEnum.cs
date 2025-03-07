using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 6, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comNivelesAutoUsuActionEnum
        {            public enum EnumcomNivelesAutoUsuAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomNivelesAutoUsuAction(comNivelesAutoUsuActionEnum.EnumcomNivelesAutoUsuAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comNivelesAutoUsuActionEnum.EnumcomNivelesAutoUsuAction.Guardar: lRetorno = "comNivelesAutoUsuGuardar"; break;
                
                case comNivelesAutoUsuActionEnum.EnumcomNivelesAutoUsuAction.Eliminar: lRetorno = "comNivelesAutoUsuEliminar"; break;
            }
            return lRetorno;
        }
    }
}
