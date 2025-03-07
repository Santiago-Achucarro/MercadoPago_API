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
    public class venSaldosPendientesTareaActionExchange : Framework.Core.Exchange{

        public String abc {
            get {
                if(((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0]["abc"] != DBNull.Value  ){
                    return ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].abc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].abc = value;
               }
	          }
        public bool IsabcNull {
             get {
                 return mParam==null || ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].IsabcNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venSaldosPendientesTareaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venSaldosPendientesTareaDS );
     }
     public venSaldosPendientesTareaActionExchange() : base( "venSaldosPendientesTarea" ) {
     }

     public venSaldosPendientesTareaActionExchange(venSaldosPendientesTareaActionEnum.EnumvenSaldosPendientesTareaAction pAccion) : base(venSaldosPendientesTareaActionEnum.GetAccionvenSaldosPendientesTareaAction(pAccion)) {
     }

     public venSaldosPendientesTareaActionExchange(venSaldosPendientesTareaActionEnum.EnumvenSaldosPendientesTareaAction pAccion, VentasCommon.venSaldosPendientesTareaDS pdsParam) : base(venSaldosPendientesTareaActionEnum.GetAccionvenSaldosPendientesTareaAction(pAccion), pdsParam) {
     }

     public venSaldosPendientesTareaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venSaldosPendientesTareaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venSaldosPendientesTareaActionExchange(VentasCommon.venSaldosPendientesTareaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venSaldosPendientesTareaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venSaldosPendientesTareaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venSaldosPendientesTareaDS)mParam;
	        }
     }
  }
}
