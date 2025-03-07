using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange
{
    // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genTareasProgramadasEjecucionActionExchange : Framework.Core.Exchange
    {
        public String Tarea_Id
        {
            get
            {
                if (((GeneralesCommon.genTareasProgramadasEjecucionDS)mParam).Principal[0]["Tarea_Id"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genTareasProgramadasEjecucionDS)mParam).Principal[0].Tarea_Id;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genTareasProgramadasEjecucionDS)mParam).Principal[0].Tarea_Id = value;
            }
        }
        public bool IsTarea_IdNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genTareasProgramadasEjecucionDS)mParam).Principal[0].IsTarea_IdNull();
            }
        }

        protected override Type GetParamType()
        {
            return typeof(GeneralesCommon.genTareasProgramadasEjecucionDS);
        }
        public genTareasProgramadasEjecucionActionExchange() : base("genTareasProgramadasEjecucion")
        {
        }

        public genTareasProgramadasEjecucionActionExchange(genTareasProgramadasEjecucionActionEnum.EnumgenTareasProgramadasEjecucionAction pAccion) : base(genTareasProgramadasEjecucionActionEnum.GetAcciongenTareasProgramadasEjecucionAction(pAccion))
        {
        }

        public genTareasProgramadasEjecucionActionExchange(genTareasProgramadasEjecucionActionEnum.EnumgenTareasProgramadasEjecucionAction pAccion, GeneralesCommon.genTareasProgramadasEjecucionDS pdsParam) : base(genTareasProgramadasEjecucionActionEnum.GetAcciongenTareasProgramadasEjecucionAction(pAccion), pdsParam)
        {
        }

        public genTareasProgramadasEjecucionActionExchange(Exchange pExch) : base()
        {
            this.Action = pExch.Action;
            this.mParam = new GeneralesCommon.genTareasProgramadasEjecucionDS();
            this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
            this.mParam.AcceptChanges();
        }

        /// <summary>
        /// El DataSet con los parámetros.
        /// </summary>
        public GeneralesCommon.genTareasProgramadasEjecucionDS Param
        {
            get
            {
                InitParam();
                return (GeneralesCommon.genTareasProgramadasEjecucionDS)mParam;
            }
        }
    }
}
