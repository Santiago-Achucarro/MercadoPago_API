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
    public class genAtributosValoresXLSActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtributosValoresXLSDS );
     }
     public genAtributosValoresXLSActionExchange() : base( "genAtributosValoresXLS" ) {
     }

     public genAtributosValoresXLSActionExchange(genAtributosValoresXLSActionEnum.EnumgenAtributosValoresXLSAction pAccion) : base(genAtributosValoresXLSActionEnum.GetAcciongenAtributosValoresXLSAction(pAccion)) {
     }

     public genAtributosValoresXLSActionExchange(genAtributosValoresXLSActionEnum.EnumgenAtributosValoresXLSAction pAccion, GeneralesCommon.genAtributosValoresXLSDS pdsParam) : base(genAtributosValoresXLSActionEnum.GetAcciongenAtributosValoresXLSAction(pAccion), pdsParam) {
     }

     public genAtributosValoresXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtributosValoresXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtributosValoresXLSDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtributosValoresXLSDS)mParam;
	        }
     }
  }
}
