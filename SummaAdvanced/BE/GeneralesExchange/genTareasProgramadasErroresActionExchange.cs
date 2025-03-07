using Framework.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesExchange
{
    // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genTareasProgramadasErroresActionExchange : Framework.Core.Exchange
    {
        public Boolean Existe
        {
            get
            {
                if (((GeneralesCommon.genTareasProgramadasErroresDS)mParam).Principal[0]["Existe"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genTareasProgramadasErroresDS)mParam).Principal[0].Existe;
                }
                else
                {
                    return false;
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genTareasProgramadasErroresDS)mParam).Principal[0].Existe = value;
            }
        }
        public bool IsExisteNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genTareasProgramadasErroresDS)mParam).Principal[0].IsExisteNull();
            }
        }

        protected override Type GetParamType()
        {
            return typeof(GeneralesCommon.genTareasProgramadasErroresDS);
        }

        public genTareasProgramadasErroresActionExchange() : base("genTareasProgramadasErrores")
        {
        }

        public genTareasProgramadasErroresActionExchange(genTareasProgramadasErroresActionEnum.EnumgenTareasProgramadasErroresAction pAccion) : base(genTareasProgramadasErroresActionEnum.GetAcciongenTareasProgramadasErroresAction(pAccion))
        {
        }

        public genTareasProgramadasErroresActionExchange(genTareasProgramadasErroresActionEnum.EnumgenTareasProgramadasErroresAction pAccion, GeneralesCommon.genTareasProgramadasErroresDS pdsParam) : base(genTareasProgramadasErroresActionEnum.GetAcciongenTareasProgramadasErroresAction(pAccion), pdsParam)
        {
        }

        public genTareasProgramadasErroresActionExchange(Exchange pExch) : base()
        {
            this.Action = pExch.Action;
            this.mParam = new GeneralesCommon.genTareasProgramadasErroresDS();
            this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
            this.mParam.AcceptChanges();
        }

        /// <summary>
        /// El DataSet con los parámetros.
        /// </summary>
        public GeneralesCommon.genTareasProgramadasErroresDS Param
        {
            get
            {
                InitParam();
                return (GeneralesCommon.genTareasProgramadasErroresDS)mParam;
            }
        }
    }
}
