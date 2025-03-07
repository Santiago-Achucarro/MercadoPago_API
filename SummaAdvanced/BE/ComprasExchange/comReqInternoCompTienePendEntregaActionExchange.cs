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
    public class comReqInternoCompTienePendEntregaActionExchange : Framework.Core.Exchange{

        public Int32 comReqInterno {
            get {
                if(((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0]["comReqInterno"] != DBNull.Value  ){
                    return ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].comReqInterno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].comReqInterno = value;
               }
	          }
        public bool IscomReqInternoNull {
             get {
                 return mParam==null || ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].IscomReqInternoNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comReqInternoCompTienePendEntregaDS );
     }
     public comReqInternoCompTienePendEntregaActionExchange() : base( "comReqInternoCompTienePendEntrega" ) {
     }

     public comReqInternoCompTienePendEntregaActionExchange(comReqInternoCompTienePendEntregaActionEnum.EnumcomReqInternoCompTienePendEntregaAction pAccion) : base(comReqInternoCompTienePendEntregaActionEnum.GetAccioncomReqInternoCompTienePendEntregaAction(pAccion)) {
     }

     public comReqInternoCompTienePendEntregaActionExchange(comReqInternoCompTienePendEntregaActionEnum.EnumcomReqInternoCompTienePendEntregaAction pAccion, ComprasCommon.comReqInternoCompTienePendEntregaDS pdsParam) : base(comReqInternoCompTienePendEntregaActionEnum.GetAccioncomReqInternoCompTienePendEntregaAction(pAccion), pdsParam) {
     }

     public comReqInternoCompTienePendEntregaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comReqInternoCompTienePendEntregaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comReqInternoCompTienePendEntregaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comReqInternoCompTienePendEntregaDS)mParam;
	        }
     }
  }
}
