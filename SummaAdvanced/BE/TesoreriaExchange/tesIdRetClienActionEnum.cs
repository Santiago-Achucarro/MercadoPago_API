using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdRetClienActionEnum
        {            public enum EnumtesIdRetClienAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdRetClienAction(tesIdRetClienActionEnum.EnumtesIdRetClienAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdRetClienActionEnum.EnumtesIdRetClienAction.Guardar: lRetorno = "tesIdRetClienGuardar"; break;
                case tesIdRetClienActionEnum.EnumtesIdRetClienAction.Datos: lRetorno = "tesIdRetClienDevolverDatos"; break;
                case tesIdRetClienActionEnum.EnumtesIdRetClienAction.Eliminar: lRetorno = "tesIdRetClienEliminar"; break;
            }
            return lRetorno;
        }
    }
}
