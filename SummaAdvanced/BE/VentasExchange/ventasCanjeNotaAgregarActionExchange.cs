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
    public class ventasCanjeNotaAgregarActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int64 venMovimientos {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal Impuestos {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Impuestos"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Impuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Impuestos = value;
               }
	          }
        public bool IsImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsImpuestosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.ventasCanjeNotaAgregarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.ventasCanjeNotaAgregarDS );
     }
     public ventasCanjeNotaAgregarActionExchange() : base( "ventasCanjeNotaAgregar" ) {
     }

     public ventasCanjeNotaAgregarActionExchange(ventasCanjeNotaAgregarActionEnum.EnumventasCanjeNotaAgregarAction pAccion) : base(ventasCanjeNotaAgregarActionEnum.GetAccionventasCanjeNotaAgregarAction(pAccion)) {
     }

     public ventasCanjeNotaAgregarActionExchange(ventasCanjeNotaAgregarActionEnum.EnumventasCanjeNotaAgregarAction pAccion, VentasCommon.ventasCanjeNotaAgregarDS pdsParam) : base(ventasCanjeNotaAgregarActionEnum.GetAccionventasCanjeNotaAgregarAction(pAccion), pdsParam) {
     }

     public ventasCanjeNotaAgregarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.ventasCanjeNotaAgregarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.ventasCanjeNotaAgregarDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.ventasCanjeNotaAgregarDS)mParam;
	        }
     }
  }
}
