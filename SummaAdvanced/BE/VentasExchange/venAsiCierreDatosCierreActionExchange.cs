using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venAsiCierreDatosCierreActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreDatosCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venAsiCierreDatosCierreDS );
     }
     public venAsiCierreDatosCierreActionExchange() : base( "venAsiCierreDatosCierre" ) {
     }

     public venAsiCierreDatosCierreActionExchange(venAsiCierreDatosCierreActionEnum.EnumvenAsiCierreDatosCierreAction pAccion) : base(venAsiCierreDatosCierreActionEnum.GetAccionvenAsiCierreDatosCierreAction(pAccion)) {
     }

     public venAsiCierreDatosCierreActionExchange(venAsiCierreDatosCierreActionEnum.EnumvenAsiCierreDatosCierreAction pAccion, VentasCommon.venAsiCierreDatosCierreDS pdsParam) : base(venAsiCierreDatosCierreActionEnum.GetAccionvenAsiCierreDatosCierreAction(pAccion), pdsParam) {
     }

     public venAsiCierreDatosCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venAsiCierreDatosCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venAsiCierreDatosCierreDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venAsiCierreDatosCierreDS)mParam;
	        }
     }
  }
}
