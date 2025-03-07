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
    public class genLinksAyudaTodosActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((GeneralesCommon.genLinksAyudaTodosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLinksAyudaTodosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLinksAyudaTodosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLinksAyudaTodosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genLinksAyudaTodosDS );
     }
     public genLinksAyudaTodosActionExchange() : base( "genLinksAyudaTodos" ) {
     }

     public genLinksAyudaTodosActionExchange(genLinksAyudaTodosActionEnum.EnumgenLinksAyudaTodosAction pAccion) : base(genLinksAyudaTodosActionEnum.GetAcciongenLinksAyudaTodosAction(pAccion)) {
     }

     public genLinksAyudaTodosActionExchange(genLinksAyudaTodosActionEnum.EnumgenLinksAyudaTodosAction pAccion, GeneralesCommon.genLinksAyudaTodosDS pdsParam) : base(genLinksAyudaTodosActionEnum.GetAcciongenLinksAyudaTodosAction(pAccion), pdsParam) {
     }

     public genLinksAyudaTodosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genLinksAyudaTodosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genLinksAyudaTodosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genLinksAyudaTodosDS)mParam;
	        }
     }
  }
}
