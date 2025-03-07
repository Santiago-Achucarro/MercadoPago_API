using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovProvEmbActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovProvEmbDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comMovProvEmbDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvEmbDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvEmbDS );
     }
     public comMovProvEmbActionExchange() : base( "comMovProvEmb" ) {
     }

     public comMovProvEmbActionExchange(comMovProvEmbActionEnum.EnumcomMovProvEmbAction pAccion) : base(comMovProvEmbActionEnum.GetAccioncomMovProvEmbAction(pAccion)) {
     }

     public comMovProvEmbActionExchange(comMovProvEmbActionEnum.EnumcomMovProvEmbAction pAccion, ComprasCommon.comMovProvEmbDS pdsParam) : base(comMovProvEmbActionEnum.GetAccioncomMovProvEmbAction(pAccion), pdsParam) {
     }

     public comMovProvEmbActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvEmbDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvEmbDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvEmbDS)mParam;
	        }
     }
  }
}
