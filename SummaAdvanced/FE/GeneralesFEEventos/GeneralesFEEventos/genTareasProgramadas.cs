using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace GeneralesFEEventos
{
    public class genTareasProgramadas
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string MostrarBtnEjecucion(GeneralesCommon.genTareasProgramadasTodasDS Exch, GeneralesCommon.genTareasProgramadasTodasDS exchNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "";
            //if ((Exch.Tareas[pIndice].EstadoActual == "Incorrecto") ||
            //    (Exch.Tareas[pIndice].Inactivo))
            if ((!Exch.Tareas[pIndice].EstadoCorrecto) || (Exch.Tareas[pIndice].Inactivo))
                lRetorno = "N";
            else
                lRetorno = "S";
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public GeneralesCommon.genTareasProgramadasTodasDS EjecutarTarea(GeneralesCommon.genTareasProgramadasTodasDS Exch, GeneralesCommon.genTareasProgramadasTodasDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genTareasProgramadasActionExchange exchTP = new GeneralesExchange.genTareasProgramadasActionExchange(GeneralesExchange.genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction.Ejecutar);

            exchTP.TareaProgramada_Id = Exch.Tareas[pIndice].TareaProgramada_Id;
            exchTP.Existe = false;
            exchTP.Param.AcceptChanges();
            exchTP = new GeneralesExchange.genTareasProgramadasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchTP, cmd));

            return exchNoPost;
        }
    }
}
