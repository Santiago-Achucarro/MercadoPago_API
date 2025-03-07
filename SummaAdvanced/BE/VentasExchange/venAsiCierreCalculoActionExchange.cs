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
    public class venAsiCierreCalculoActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venAsiCierreCalculoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venAsiCierreCalculoDS );
     }
     public venAsiCierreCalculoActionExchange() : base( "venAsiCierreCalculo" ) {
     }

     public venAsiCierreCalculoActionExchange(venAsiCierreCalculoActionEnum.EnumvenAsiCierreCalculoAction pAccion) : base(venAsiCierreCalculoActionEnum.GetAccionvenAsiCierreCalculoAction(pAccion)) {
     }

     public venAsiCierreCalculoActionExchange(venAsiCierreCalculoActionEnum.EnumvenAsiCierreCalculoAction pAccion, VentasCommon.venAsiCierreCalculoDS pdsParam) : base(venAsiCierreCalculoActionEnum.GetAccionvenAsiCierreCalculoAction(pAccion), pdsParam) {
     }

     public venAsiCierreCalculoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venAsiCierreCalculoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venAsiCierreCalculoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venAsiCierreCalculoDS)mParam;
	        }
     }
  }
}
