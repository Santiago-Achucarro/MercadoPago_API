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
    public class comProvedoresXlsActionExchange : Framework.Core.Exchange{

        public String Archivo {
            get {
                if(((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvedoresXlsDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProvedoresXlsDS );
     }
     public comProvedoresXlsActionExchange() : base( "comProvedoresXls" ) {
     }

     public comProvedoresXlsActionExchange(comProvedoresXlsActionEnum.EnumcomProvedoresXlsAction pAccion) : base(comProvedoresXlsActionEnum.GetAccioncomProvedoresXlsAction(pAccion)) {
     }

     public comProvedoresXlsActionExchange(comProvedoresXlsActionEnum.EnumcomProvedoresXlsAction pAccion, ComprasCommon.comProvedoresXlsDS pdsParam) : base(comProvedoresXlsActionEnum.GetAccioncomProvedoresXlsAction(pAccion), pdsParam) {
     }

     public comProvedoresXlsActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProvedoresXlsDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProvedoresXlsDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProvedoresXlsDS)mParam;
	        }
     }
  }
}
