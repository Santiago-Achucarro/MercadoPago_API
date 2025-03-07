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
    public class genTareasProgramadasTodasActionExchange : Framework.Core.Exchange
    {
        public Boolean Existe
        {
            get
            {
                if (((GeneralesCommon.genTareasProgramadasTodasDS)mParam).Principal[0]["Existe"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genTareasProgramadasTodasDS)mParam).Principal[0].Existe;
                }
                else
                {
                    return false;
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genTareasProgramadasTodasDS)mParam).Principal[0].Existe = value;
            }
        }
        public bool IsExisteNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genTareasProgramadasTodasDS)mParam).Principal[0].IsExisteNull();
            }
        }



        protected override Type GetParamType()
        {
            return typeof(GeneralesCommon.genTareasProgramadasTodasDS);
        }
        public genTareasProgramadasTodasActionExchange() : base("genTareasProgramadasTodas")
        {
        }

        public genTareasProgramadasTodasActionExchange(genTareasProgramadasTodasActionEnum.EnumgenTareasProgramadasTodasAction pAccion) : base(genTareasProgramadasTodasActionEnum.GetAcciongenTareasProgramadasTodasAction(pAccion))
        {
        }

        public genTareasProgramadasTodasActionExchange(genTareasProgramadasTodasActionEnum.EnumgenTareasProgramadasTodasAction pAccion, GeneralesCommon.genTareasProgramadasTodasDS pdsParam) : base(genTareasProgramadasTodasActionEnum.GetAcciongenTareasProgramadasTodasAction(pAccion), pdsParam)
        {
        }

        public genTareasProgramadasTodasActionExchange(Exchange pExch) : base()
        {
            this.Action = pExch.Action;
            this.mParam = new GeneralesCommon.genTareasProgramadasTodasDS();
            this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
            this.mParam.AcceptChanges();
        }

        /// <summary>
        /// El DataSet con los parámetros.
        /// </summary>
        public GeneralesCommon.genTareasProgramadasTodasDS Param
        {
            get
            {
                InitParam();
                return (GeneralesCommon.genTareasProgramadasTodasDS)mParam;
            }
        }
    }
}
