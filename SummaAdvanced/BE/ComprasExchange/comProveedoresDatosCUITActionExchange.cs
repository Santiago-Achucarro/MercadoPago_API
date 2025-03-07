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
    public class comProveedoresDatosCUITActionExchange : Framework.Core.Exchange{

        public String Proveed_Id {
            get {
                if(((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDatosCUITDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresDatosCUITDS );
     }
     public comProveedoresDatosCUITActionExchange() : base( "comProveedoresDatosCUIT" ) {
     }

     public comProveedoresDatosCUITActionExchange(comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction pAccion) : base(comProveedoresDatosCUITActionEnum.GetAccioncomProveedoresDatosCUITAction(pAccion)) {
     }

     public comProveedoresDatosCUITActionExchange(comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction pAccion, ComprasCommon.comProveedoresDatosCUITDS pdsParam) : base(comProveedoresDatosCUITActionEnum.GetAccioncomProveedoresDatosCUITAction(pAccion), pdsParam) {
     }

     public comProveedoresDatosCUITActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresDatosCUITDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresDatosCUITDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresDatosCUITDS)mParam;
	        }
     }
  }
}
