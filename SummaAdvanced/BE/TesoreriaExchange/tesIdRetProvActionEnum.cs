using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdRetProvActionEnum
        {            public enum EnumtesIdRetProvAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdRetProvAction(tesIdRetProvActionEnum.EnumtesIdRetProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdRetProvActionEnum.EnumtesIdRetProvAction.Guardar: lRetorno = "tesIdRetProvGuardar"; break;
                case tesIdRetProvActionEnum.EnumtesIdRetProvAction.Datos: lRetorno = "tesIdRetProvDevolverDatos"; break;
                case tesIdRetProvActionEnum.EnumtesIdRetProvAction.Eliminar: lRetorno = "tesIdRetProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
