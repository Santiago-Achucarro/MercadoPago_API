using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genContadorSegmentoActionEnum
        {            public enum EnumgenContadorSegmentoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenContadorSegmentoAction(genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction.Guardar: lRetorno = "genContadorSegmentoGuardar"; break;
                case genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction.Datos: lRetorno = "genContadorSegmentoDevolverDatos"; break;
                case genContadorSegmentoActionEnum.EnumgenContadorSegmentoAction.Eliminar: lRetorno = "genContadorSegmentoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
