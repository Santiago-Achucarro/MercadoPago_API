using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genContadorSegmentoDatosTodosActionEnum
        {            public enum EnumgenContadorSegmentoDatosTodosAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenContadorSegmentoDatosTodosAction(genContadorSegmentoDatosTodosActionEnum.EnumgenContadorSegmentoDatosTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genContadorSegmentoDatosTodosActionEnum.EnumgenContadorSegmentoDatosTodosAction.Guardar: lRetorno = "genContadorSegmentoDatosTodosGuardar"; break;
                case genContadorSegmentoDatosTodosActionEnum.EnumgenContadorSegmentoDatosTodosAction.Datos: lRetorno = "genContadorSegmentoDatosTodosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
