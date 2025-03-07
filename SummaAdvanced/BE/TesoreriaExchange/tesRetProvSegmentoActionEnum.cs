using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 24 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesRetProvSegmentoActionEnum
    {
        public enum EnumtesRetProvSegmentoAction
        {
            Guardar
        }
        public static string GetAcciontesRetProvSegmentoAction(tesRetProvSegmentoActionEnum.EnumtesRetProvSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRetProvSegmentoActionEnum.EnumtesRetProvSegmentoAction.Guardar: lRetorno = "tesRetProvSegmentoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
