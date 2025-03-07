using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdVariosActionEnum
        {            public enum EnumtesIdVariosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdVariosAction(tesIdVariosActionEnum.EnumtesIdVariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdVariosActionEnum.EnumtesIdVariosAction.Guardar: lRetorno = "tesIdVariosGuardar"; break;
                case tesIdVariosActionEnum.EnumtesIdVariosAction.Datos: lRetorno = "tesIdVariosDevolverDatos"; break;
                case tesIdVariosActionEnum.EnumtesIdVariosAction.Eliminar: lRetorno = "tesIdVariosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
