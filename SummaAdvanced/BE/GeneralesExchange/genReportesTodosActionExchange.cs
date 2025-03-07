using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genReportesTodosActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((GeneralesCommon.genReportesTodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReportesTodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReportesTodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReportesTodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genReportesTodosDS );
     }
     public genReportesTodosActionExchange() : base( "genReportesTodos" ) {
     }

     public genReportesTodosActionExchange(genReportesTodosActionEnum.EnumgenReportesTodosAction pAccion) : base(genReportesTodosActionEnum.GetAcciongenReportesTodosAction(pAccion)) {
     }

     public genReportesTodosActionExchange(genReportesTodosActionEnum.EnumgenReportesTodosAction pAccion, GeneralesCommon.genReportesTodosDS pdsParam) : base(genReportesTodosActionEnum.GetAcciongenReportesTodosAction(pAccion), pdsParam) {
     }

     public genReportesTodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genReportesTodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genReportesTodosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genReportesTodosDS)mParam;
	        }
     }
  }
}
