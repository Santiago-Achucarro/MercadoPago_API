using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conAsiDistribuirActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsiDistribuirDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiDistribuirDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiDistribuirDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiDistribuirDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsiDistribuirDS );
     }
     public conAsiDistribuirActionExchange() : base( "conAsiDistribuir" ) {
     }

     public conAsiDistribuirActionExchange(conAsiDistribuirActionEnum.EnumconAsiDistribuirAction pAccion) : base(conAsiDistribuirActionEnum.GetAccionconAsiDistribuirAction(pAccion)) {
     }

     public conAsiDistribuirActionExchange(conAsiDistribuirActionEnum.EnumconAsiDistribuirAction pAccion, ContabilidadCommon.conAsiDistribuirDS pdsParam) : base(conAsiDistribuirActionEnum.GetAccionconAsiDistribuirAction(pAccion), pdsParam) {
     }

     public conAsiDistribuirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsiDistribuirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsiDistribuirDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsiDistribuirDS)mParam;
	        }
     }
  }
}
