using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesExchange
{

    public static class genTareasProgramadasEjecucionActionEnum
    {
        public enum EnumgenTareasProgramadasEjecucionAction
        {
            Ejecutar
        }
        public static string GetAcciongenTareasProgramadasEjecucionAction(genTareasProgramadasEjecucionActionEnum.EnumgenTareasProgramadasEjecucionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTareasProgramadasEjecucionActionEnum.EnumgenTareasProgramadasEjecucionAction.Ejecutar: lRetorno = "genTareasProgramadasEjecucionEjecutar"; break;
            }
            return lRetorno;
        }
    }

}
