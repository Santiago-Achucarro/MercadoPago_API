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
    public class comListaNegraActionExchange : Framework.Core.Exchange{

        public String Archivo {
            get {
                if(((ComprasCommon.comListaNegraDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comListaNegraDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comListaNegraDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comListaNegraDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comListaNegraDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comListaNegraDS );
     }
     public comListaNegraActionExchange() : base( "comListaNegra" ) {
     }

     public comListaNegraActionExchange(comListaNegraActionEnum.EnumcomListaNegraAction pAccion) : base(comListaNegraActionEnum.GetAccioncomListaNegraAction(pAccion)) {
     }

     public comListaNegraActionExchange(comListaNegraActionEnum.EnumcomListaNegraAction pAccion, ComprasCommon.comListaNegraDS pdsParam) : base(comListaNegraActionEnum.GetAccioncomListaNegraAction(pAccion), pdsParam) {
     }

     public comListaNegraActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comListaNegraDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comListaNegraDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comListaNegraDS)mParam;
	        }
     }
  }
}
