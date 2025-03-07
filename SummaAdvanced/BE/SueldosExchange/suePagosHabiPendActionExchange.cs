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
    public class suePagosHabiPendActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPendDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePagosHabiPendDS );
     }
     public suePagosHabiPendActionExchange() : base( "suePagosHabiPend" ) {
     }

     public suePagosHabiPendActionExchange(suePagosHabiPendActionEnum.EnumsuePagosHabiPendAction pAccion) : base(suePagosHabiPendActionEnum.GetAccionsuePagosHabiPendAction(pAccion)) {
     }

     public suePagosHabiPendActionExchange(suePagosHabiPendActionEnum.EnumsuePagosHabiPendAction pAccion, SueldosCommon.suePagosHabiPendDS pdsParam) : base(suePagosHabiPendActionEnum.GetAccionsuePagosHabiPendAction(pAccion), pdsParam) {
     }

     public suePagosHabiPendActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePagosHabiPendDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePagosHabiPendDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePagosHabiPendDS)mParam;
	        }
     }
  }
}
