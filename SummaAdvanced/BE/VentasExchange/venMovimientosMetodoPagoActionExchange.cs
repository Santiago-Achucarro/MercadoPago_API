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
    public class venMovimientosMetodoPagoActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String CuentaPago {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["CuentaPago"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].CuentaPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].CuentaPago = value;
               }
	          }
        public bool IsCuentaPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsCuentaPagoNull();
             }
	        }
        public String NMetodoPago {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["NMetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].NMetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].NMetodoPago = value;
               }
	          }
        public bool IsNMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsNMetodoPagoNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosMetodoPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosMetodoPagoDS );
     }
     public venMovimientosMetodoPagoActionExchange() : base( "venMovimientosMetodoPago" ) {
     }

     public venMovimientosMetodoPagoActionExchange(venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction pAccion) : base(venMovimientosMetodoPagoActionEnum.GetAccionvenMovimientosMetodoPagoAction(pAccion)) {
     }

     public venMovimientosMetodoPagoActionExchange(venMovimientosMetodoPagoActionEnum.EnumvenMovimientosMetodoPagoAction pAccion, VentasCommon.venMovimientosMetodoPagoDS pdsParam) : base(venMovimientosMetodoPagoActionEnum.GetAccionvenMovimientosMetodoPagoAction(pAccion), pdsParam) {
     }

     public venMovimientosMetodoPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosMetodoPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosMetodoPagoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosMetodoPagoDS)mParam;
	        }
     }
  }
}
