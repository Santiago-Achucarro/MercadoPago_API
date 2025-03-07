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
    public class sueLiqVarGlobalesActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueLiqVarGlobalesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueLiqVarGlobalesDS );
     }
     public sueLiqVarGlobalesActionExchange() : base( "sueLiqVarGlobales" ) {
     }

     public sueLiqVarGlobalesActionExchange(sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction pAccion) : base(sueLiqVarGlobalesActionEnum.GetAccionsueLiqVarGlobalesAction(pAccion)) {
     }

     public sueLiqVarGlobalesActionExchange(sueLiqVarGlobalesActionEnum.EnumsueLiqVarGlobalesAction pAccion, SueldosCommon.sueLiqVarGlobalesDS pdsParam) : base(sueLiqVarGlobalesActionEnum.GetAccionsueLiqVarGlobalesAction(pAccion), pdsParam) {
     }

     public sueLiqVarGlobalesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueLiqVarGlobalesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueLiqVarGlobalesDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueLiqVarGlobalesDS)mParam;
	        }
     }
  }
}
