using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class suePersonalXLSActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((SueldosCommon.suePersonalXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePersonalXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePersonalXLSDS );
     }
     public suePersonalXLSActionExchange() : base( "suePersonalXLS" ) {
     }

     public suePersonalXLSActionExchange(suePersonalXLSActionEnum.EnumsuePersonalXLSAction pAccion) : base(suePersonalXLSActionEnum.GetAccionsuePersonalXLSAction(pAccion)) {
     }

     public suePersonalXLSActionExchange(suePersonalXLSActionEnum.EnumsuePersonalXLSAction pAccion, SueldosCommon.suePersonalXLSDS pdsParam) : base(suePersonalXLSActionEnum.GetAccionsuePersonalXLSAction(pAccion), pdsParam) {
     }

     public suePersonalXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePersonalXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePersonalXLSDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePersonalXLSDS)mParam;
	        }
     }
  }
}
