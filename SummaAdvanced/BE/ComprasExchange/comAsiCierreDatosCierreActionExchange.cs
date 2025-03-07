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
    public class comAsiCierreDatosCierreActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreDatosCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comAsiCierreDatosCierreDS );
     }
     public comAsiCierreDatosCierreActionExchange() : base( "comAsiCierreDatosCierre" ) {
     }

     public comAsiCierreDatosCierreActionExchange(comAsiCierreDatosCierreActionEnum.EnumcomAsiCierreDatosCierreAction pAccion) : base(comAsiCierreDatosCierreActionEnum.GetAccioncomAsiCierreDatosCierreAction(pAccion)) {
     }

     public comAsiCierreDatosCierreActionExchange(comAsiCierreDatosCierreActionEnum.EnumcomAsiCierreDatosCierreAction pAccion, ComprasCommon.comAsiCierreDatosCierreDS pdsParam) : base(comAsiCierreDatosCierreActionEnum.GetAccioncomAsiCierreDatosCierreAction(pAccion), pdsParam) {
     }

     public comAsiCierreDatosCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comAsiCierreDatosCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comAsiCierreDatosCierreDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comAsiCierreDatosCierreDS)mParam;
	        }
     }
  }
}
