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
    public class comOrdenCompTienePendEntregaActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendEntregaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompTienePendEntregaDS );
     }
     public comOrdenCompTienePendEntregaActionExchange() : base( "comOrdenCompTienePendEntrega" ) {
     }

     public comOrdenCompTienePendEntregaActionExchange(comOrdenCompTienePendEntregaActionEnum.EnumcomOrdenCompTienePendEntregaAction pAccion) : base(comOrdenCompTienePendEntregaActionEnum.GetAccioncomOrdenCompTienePendEntregaAction(pAccion)) {
     }

     public comOrdenCompTienePendEntregaActionExchange(comOrdenCompTienePendEntregaActionEnum.EnumcomOrdenCompTienePendEntregaAction pAccion, ComprasCommon.comOrdenCompTienePendEntregaDS pdsParam) : base(comOrdenCompTienePendEntregaActionEnum.GetAccioncomOrdenCompTienePendEntregaAction(pAccion), pdsParam) {
     }

     public comOrdenCompTienePendEntregaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompTienePendEntregaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompTienePendEntregaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompTienePendEntregaDS)mParam;
	        }
     }
  }
}
