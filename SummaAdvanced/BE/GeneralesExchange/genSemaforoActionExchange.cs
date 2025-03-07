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
    public class genSemaforoActionExchange : Framework.Core.Exchange{

        public String Semaforo {
            get {
                if(((GeneralesCommon.genSemaforoDS)mParam).Principal[0]["Semaforo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSemaforoDS)mParam).Principal[0].Semaforo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSemaforoDS)mParam).Principal[0].Semaforo = value;
               }
	          }
        public bool IsSemaforoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSemaforoDS)mParam).Principal[0].IsSemaforoNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSemaforoDS );
     }
     public genSemaforoActionExchange() : base( "genSemaforo" ) {
     }

     public genSemaforoActionExchange(genSemaforoActionEnum.EnumgenSemaforoAction pAccion) : base(genSemaforoActionEnum.GetAcciongenSemaforoAction(pAccion)) {
     }

     public genSemaforoActionExchange(genSemaforoActionEnum.EnumgenSemaforoAction pAccion, GeneralesCommon.genSemaforoDS pdsParam) : base(genSemaforoActionEnum.GetAcciongenSemaforoAction(pAccion), pdsParam) {
     }

     public genSemaforoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSemaforoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSemaforoDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSemaforoDS)mParam;
	        }
     }
  }
}
