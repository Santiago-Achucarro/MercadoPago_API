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
    public class suePagosHabiPorEmpleadoPendActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePagosHabiPorEmpleadoPendDS );
     }
     public suePagosHabiPorEmpleadoPendActionExchange() : base( "suePagosHabiPorEmpleadoPend" ) {
     }

     public suePagosHabiPorEmpleadoPendActionExchange(suePagosHabiPorEmpleadoPendActionEnum.EnumsuePagosHabiPorEmpleadoPendAction pAccion) : base(suePagosHabiPorEmpleadoPendActionEnum.GetAccionsuePagosHabiPorEmpleadoPendAction(pAccion)) {
     }

     public suePagosHabiPorEmpleadoPendActionExchange(suePagosHabiPorEmpleadoPendActionEnum.EnumsuePagosHabiPorEmpleadoPendAction pAccion, SueldosCommon.suePagosHabiPorEmpleadoPendDS pdsParam) : base(suePagosHabiPorEmpleadoPendActionEnum.GetAccionsuePagosHabiPorEmpleadoPendAction(pAccion), pdsParam) {
     }

     public suePagosHabiPorEmpleadoPendActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePagosHabiPorEmpleadoPendDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePagosHabiPorEmpleadoPendDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePagosHabiPorEmpleadoPendDS)mParam;
	        }
     }
  }
}
