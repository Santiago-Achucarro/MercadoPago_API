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
    public class comOrdenCompTienePendFactActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompTienePendFactDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompTienePendFactDS );
     }
     public comOrdenCompTienePendFactActionExchange() : base( "comOrdenCompTienePendFact" ) {
     }

     public comOrdenCompTienePendFactActionExchange(comOrdenCompTienePendFactActionEnum.EnumcomOrdenCompTienePendFactAction pAccion) : base(comOrdenCompTienePendFactActionEnum.GetAccioncomOrdenCompTienePendFactAction(pAccion)) {
     }

     public comOrdenCompTienePendFactActionExchange(comOrdenCompTienePendFactActionEnum.EnumcomOrdenCompTienePendFactAction pAccion, ComprasCommon.comOrdenCompTienePendFactDS pdsParam) : base(comOrdenCompTienePendFactActionEnum.GetAccioncomOrdenCompTienePendFactAction(pAccion), pdsParam) {
     }

     public comOrdenCompTienePendFactActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompTienePendFactDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompTienePendFactDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompTienePendFactDS)mParam;
	        }
     }
  }
}
