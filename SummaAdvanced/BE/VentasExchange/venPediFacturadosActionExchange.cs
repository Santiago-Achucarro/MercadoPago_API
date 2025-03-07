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
    public class venPediFacturadosActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String PedidoStr {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["PedidoStr"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].PedidoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].PedidoStr = value;
               }
	          }
        public bool IsPedidoStrNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsPedidoStrNull();
             }
	        }
        public Int32 Reparto_Id {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["Reparto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Reparto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Reparto_Id = value;
               }
	          }
        public bool IsReparto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsReparto_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediFacturadosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediFacturadosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediFacturadosDS );
     }
     public venPediFacturadosActionExchange() : base( "venPediFacturados" ) {
     }

     public venPediFacturadosActionExchange(venPediFacturadosActionEnum.EnumvenPediFacturadosAction pAccion) : base(venPediFacturadosActionEnum.GetAccionvenPediFacturadosAction(pAccion)) {
     }

     public venPediFacturadosActionExchange(venPediFacturadosActionEnum.EnumvenPediFacturadosAction pAccion, VentasCommon.venPediFacturadosDS pdsParam) : base(venPediFacturadosActionEnum.GetAccionvenPediFacturadosAction(pAccion), pdsParam) {
     }

     public venPediFacturadosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediFacturadosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediFacturadosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediFacturadosDS)mParam;
	        }
     }
  }
}
