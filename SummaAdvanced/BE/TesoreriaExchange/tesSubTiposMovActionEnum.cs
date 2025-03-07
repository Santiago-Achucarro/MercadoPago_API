using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 25 de febrero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesSubTiposMovActionEnum
        {            public enum EnumtesSubTiposMovAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesSubTiposMovAction(tesSubTiposMovActionEnum.EnumtesSubTiposMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesSubTiposMovActionEnum.EnumtesSubTiposMovAction.Guardar: lRetorno = "tesSubTiposMovGuardar"; break;
                case tesSubTiposMovActionEnum.EnumtesSubTiposMovAction.Datos: lRetorno = "tesSubTiposMovDevolverDatos"; break;
                case tesSubTiposMovActionEnum.EnumtesSubTiposMovAction.Eliminar: lRetorno = "tesSubTiposMovEliminar"; break;
            }
            return lRetorno;
        }
    }
}
