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
    public class comOrdenCompPendAutoActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompPendAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompPendAutoDS );
     }
     public comOrdenCompPendAutoActionExchange() : base( "comOrdenCompPendAuto" ) {
     }

     public comOrdenCompPendAutoActionExchange(comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction pAccion) : base(comOrdenCompPendAutoActionEnum.GetAccioncomOrdenCompPendAutoAction(pAccion)) {
     }

     public comOrdenCompPendAutoActionExchange(comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction pAccion, ComprasCommon.comOrdenCompPendAutoDS pdsParam) : base(comOrdenCompPendAutoActionEnum.GetAccioncomOrdenCompPendAutoAction(pAccion), pdsParam) {
     }

     public comOrdenCompPendAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompPendAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompPendAutoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompPendAutoDS)mParam;
	        }
     }
  }
}
