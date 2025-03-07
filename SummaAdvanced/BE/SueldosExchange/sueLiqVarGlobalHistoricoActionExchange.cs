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
    public class sueLiqVarGlobalHistoricoActionExchange : Framework.Core.Exchange{

        public Int32 VarGlobal_Id {
            get {
                if(((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0]["VarGlobal_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].VarGlobal_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].VarGlobal_Id = value;
               }
	          }
        public bool IsVarGlobal_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].IsVarGlobal_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqVarGlobalHistoricoDS );
     }
     public sueLiqVarGlobalHistoricoActionExchange() : base( "sueLiqVarGlobalHistorico" ) {
     }

     public sueLiqVarGlobalHistoricoActionExchange(sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction pAccion) : base(sueLiqVarGlobalHistoricoActionEnum.GetAccionsueLiqVarGlobalHistoricoAction(pAccion)) {
     }

     public sueLiqVarGlobalHistoricoActionExchange(sueLiqVarGlobalHistoricoActionEnum.EnumsueLiqVarGlobalHistoricoAction pAccion, SueldosCommon.sueLiqVarGlobalHistoricoDS pdsParam) : base(sueLiqVarGlobalHistoricoActionEnum.GetAccionsueLiqVarGlobalHistoricoAction(pAccion), pdsParam) {
     }

     public sueLiqVarGlobalHistoricoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqVarGlobalHistoricoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqVarGlobalHistoricoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqVarGlobalHistoricoDS)mParam;
	        }
     }
  }
}
