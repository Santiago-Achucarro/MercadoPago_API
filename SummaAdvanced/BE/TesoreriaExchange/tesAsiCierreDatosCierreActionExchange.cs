using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesAsiCierreDatosCierreActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAsiCierreDatosCierreDS );
     }
     public tesAsiCierreDatosCierreActionExchange() : base( "tesAsiCierreDatosCierre" ) {
     }

     public tesAsiCierreDatosCierreActionExchange(tesAsiCierreDatosCierreActionEnum.EnumtesAsiCierreDatosCierreAction pAccion) : base(tesAsiCierreDatosCierreActionEnum.GetAcciontesAsiCierreDatosCierreAction(pAccion)) {
     }

     public tesAsiCierreDatosCierreActionExchange(tesAsiCierreDatosCierreActionEnum.EnumtesAsiCierreDatosCierreAction pAccion, TesoreriaCommon.tesAsiCierreDatosCierreDS pdsParam) : base(tesAsiCierreDatosCierreActionEnum.GetAcciontesAsiCierreDatosCierreAction(pAccion), pdsParam) {
     }

     public tesAsiCierreDatosCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAsiCierreDatosCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAsiCierreDatosCierreDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAsiCierreDatosCierreDS)mParam;
	        }
     }
  }
}
