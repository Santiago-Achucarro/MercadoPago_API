using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesExchange
{
    public static class genTareasProgramadasErroresActionEnum
    {
        public enum EnumgenTareasProgramadasErroresAction
        {
            Datos, Limpiar 
        }
        public static string GetAcciongenTareasProgramadasErroresAction(genTareasProgramadasErroresActionEnum.EnumgenTareasProgramadasErroresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTareasProgramadasErroresActionEnum.EnumgenTareasProgramadasErroresAction.Limpiar: lRetorno = "genTareasProgramadasErroresLimpiar"; break;
                case genTareasProgramadasErroresActionEnum.EnumgenTareasProgramadasErroresAction.Datos: lRetorno = "genTareasProgramadasErroresDevolverDatos"; break;
            }
            return lRetorno;
        }



    }
}
