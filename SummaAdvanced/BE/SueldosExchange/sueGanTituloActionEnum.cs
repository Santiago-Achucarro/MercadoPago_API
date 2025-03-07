using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, August 23, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueGanTituloActionEnum
        {            public enum EnumsueGanTituloAction
            {
                Guardar,Datos,Eliminar,DescargarWS
            }
        public static string GetAccionsueGanTituloAction(sueGanTituloActionEnum.EnumsueGanTituloAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueGanTituloActionEnum.EnumsueGanTituloAction.Guardar: lRetorno = "sueGanTituloGuardar"; break;
                case sueGanTituloActionEnum.EnumsueGanTituloAction.Datos: lRetorno = "sueGanTituloDevolverDatos"; break;
                case sueGanTituloActionEnum.EnumsueGanTituloAction.Eliminar: lRetorno = "sueGanTituloEliminar"; break;
                case sueGanTituloActionEnum.EnumsueGanTituloAction.DescargarWS: lRetorno = "sueGanTituloDescargarWS"; break;
            }
            return lRetorno;
        }
    }
}
