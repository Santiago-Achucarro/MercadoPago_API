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
    public class comAsiCierreCalculoActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCalculoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comAsiCierreCalculoDS );
     }
     public comAsiCierreCalculoActionExchange() : base( "comAsiCierreCalculo" ) {
     }

     public comAsiCierreCalculoActionExchange(comAsiCierreCalculoActionEnum.EnumcomAsiCierreCalculoAction pAccion) : base(comAsiCierreCalculoActionEnum.GetAccioncomAsiCierreCalculoAction(pAccion)) {
     }

     public comAsiCierreCalculoActionExchange(comAsiCierreCalculoActionEnum.EnumcomAsiCierreCalculoAction pAccion, ComprasCommon.comAsiCierreCalculoDS pdsParam) : base(comAsiCierreCalculoActionEnum.GetAccioncomAsiCierreCalculoAction(pAccion), pdsParam) {
     }

     public comAsiCierreCalculoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comAsiCierreCalculoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comAsiCierreCalculoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comAsiCierreCalculoDS)mParam;
	        }
     }
  }
}
