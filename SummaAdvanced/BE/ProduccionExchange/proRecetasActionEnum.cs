using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasActionEnum
        {            public enum EnumproRecetasAction
            {
                Guardar,Datos,Eliminar, AsignarDefecto, Pegar
        }
        public static string GetAccionproRecetasAction(proRecetasActionEnum.EnumproRecetasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasActionEnum.EnumproRecetasAction.Guardar: lRetorno = "proRecetasGuardar"; break;
                case proRecetasActionEnum.EnumproRecetasAction.Datos: lRetorno = "proRecetasDevolverDatos"; break;
                case proRecetasActionEnum.EnumproRecetasAction.Eliminar: lRetorno = "proRecetasEliminar"; break;
                case proRecetasActionEnum.EnumproRecetasAction.AsignarDefecto: lRetorno = "proRecetasAsignarDefecto"; break;
                case proRecetasActionEnum.EnumproRecetasAction.Pegar:lRetorno = "proRecetasPegar"; break;
                    
            }
            return lRetorno;
        }
    }
}
