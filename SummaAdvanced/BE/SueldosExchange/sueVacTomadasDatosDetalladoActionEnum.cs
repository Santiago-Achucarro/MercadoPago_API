using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, October 9, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVacTomadasDatosDetalladoActionEnum
        {            public enum EnumsueVacTomadasDatosDetalladoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueVacTomadasDatosDetalladoAction(sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction.Guardar: lRetorno = "sueVacTomadasDatosDetalladoGuardar"; break;
                case sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction.Datos: lRetorno = "sueVacTomadasDatosDetalladoDevolverDatos"; break;
                case sueVacTomadasDatosDetalladoActionEnum.EnumsueVacTomadasDatosDetalladoAction.Eliminar: lRetorno = "sueVacTomadasDatosDetalladoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
