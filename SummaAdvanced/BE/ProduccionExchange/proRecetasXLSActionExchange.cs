using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proRecetasXLSActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasXLSDS );
     }
     public proRecetasXLSActionExchange() : base( "proRecetasXLS" ) {
     }

     public proRecetasXLSActionExchange(proRecetasXLSActionEnum.EnumproRecetasXLSAction pAccion) : base(proRecetasXLSActionEnum.GetAccionproRecetasXLSAction(pAccion)) {
     }

     public proRecetasXLSActionExchange(proRecetasXLSActionEnum.EnumproRecetasXLSAction pAccion, ProduccionCommon.proRecetasXLSDS pdsParam) : base(proRecetasXLSActionEnum.GetAccionproRecetasXLSAction(pAccion), pdsParam) {
     }

     public proRecetasXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasXLSDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasXLSDS)mParam;
	        }
     }
  }
}
