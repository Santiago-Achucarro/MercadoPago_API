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
    public class venMovConStockCrActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Int32 RenglonReferencia {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["RenglonReferencia"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].RenglonReferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].RenglonReferencia = value;
               }
	          }
        public bool IsRenglonReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsRenglonReferenciaNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal CantFacturada {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantFacturada"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantFacturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantFacturada = value;
               }
	          }
        public bool IsCantFacturadaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantFacturadaNull();
             }
	        }
        public Decimal CantEntregada {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantEntregada"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantEntregada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantEntregada = value;
               }
	          }
        public bool IsCantEntregadaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantEntregadaNull();
             }
	        }
        public Decimal CantPendiente {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantPendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantPendiente = value;
               }
	          }
        public bool IsCantPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantPendienteNull();
             }
	        }
        public Decimal CantOriginal {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantOriginal = value;
               }
	          }
        public bool IsCantOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantOriginalNull();
             }
	        }
        public String MedidaAlterna {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["MedidaAlterna"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].MedidaAlterna;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].MedidaAlterna = value;
               }
	          }
        public bool IsMedidaAlternaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsMedidaAlternaNull();
             }
	        }
        public Decimal CantidadAlternaForm {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantidadAlternaForm"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantidadAlternaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantidadAlternaForm = value;
               }
	          }
        public bool IsCantidadAlternaFormNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantidadAlternaFormNull();
             }
	        }
        public String TipoPrecio {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["TipoPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].TipoPrecio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].TipoPrecio = value;
               }
	          }
        public bool IsTipoPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsTipoPrecioNull();
             }
	        }
        public Decimal PrecioForm {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioForm = value;
               }
	          }
        public bool IsPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioFormNull();
             }
	        }
        public Decimal PrecioSinIva {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioSinIva"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioSinIva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioSinIva = value;
               }
	          }
        public bool IsPrecioSinIvaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioSinIvaNull();
             }
	        }
        public Decimal PrecioLista {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioLista"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioLista;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioLista = value;
               }
	          }
        public bool IsPrecioListaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioListaNull();
             }
	        }
        public Decimal PrecioVenta {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioVenta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioVenta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioVenta = value;
               }
	          }
        public bool IsPrecioVentaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioVentaNull();
             }
	        }
        public Decimal PrecioFormImpuesto {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioFormImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuesto = value;
               }
	          }
        public bool IsPrecioFormImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioFormImpuestoNull();
             }
	        }
        public Decimal PrecioFormImpuestoBon {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioFormImpuestoBon"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuestoBon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuestoBon = value;
               }
	          }
        public bool IsPrecioFormImpuestoBonNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioFormImpuestoBonNull();
             }
	        }
        public Decimal PrecioFormImpuestoTot {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["PrecioFormImpuestoTot"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuestoTot;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].PrecioFormImpuestoTot = value;
               }
	          }
        public bool IsPrecioFormImpuestoTotNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsPrecioFormImpuestoTotNull();
             }
	        }
        public Decimal ComiPorce {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["ComiPorce"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ComiPorce;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ComiPorce = value;
               }
	          }
        public bool IsComiPorceNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsComiPorceNull();
             }
	        }
        public Decimal Bonificacion {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Bonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Bonificacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Bonificacion = value;
               }
	          }
        public bool IsBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsBonificacionNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal SubTotalFormImpuesto {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["SubTotalFormImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].SubTotalFormImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].SubTotalFormImpuesto = value;
               }
	          }
        public bool IsSubTotalFormImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsSubTotalFormImpuestoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public DateTime FechaEntrega {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["FechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].FechaEntrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].FechaEntrega = value;
               }
	          }
        public bool IsFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsFechaEntregaNull();
             }
	        }
        public Decimal CantidadAduana {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantidadAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantidadAduana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantidadAduana = value;
               }
	          }
        public bool IsCantidadAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantidadAduanaNull();
             }
	        }
        public String UnidadAduana {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["UnidadAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].UnidadAduana;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].UnidadAduana = value;
               }
	          }
        public bool IsUnidadAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsUnidadAduanaNull();
             }
	        }
        public Decimal ValorUnitarioAduana {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["ValorUnitarioAduana"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ValorUnitarioAduana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ValorUnitarioAduana = value;
               }
	          }
        public bool IsValorUnitarioAduanaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsValorUnitarioAduanaNull();
             }
	        }
        public Decimal ValorDolares {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["ValorDolares"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ValorDolares;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].ValorDolares = value;
               }
	          }
        public bool IsValorDolaresNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsValorDolaresNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Despacho_Id {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public Decimal CantEntregadaForm {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["CantEntregadaForm"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantEntregadaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].CantEntregadaForm = value;
               }
	          }
        public bool IsCantEntregadaFormNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsCantEntregadaFormNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovConStockCrDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovConStockCrDS );
     }
     public venMovConStockCrActionExchange() : base( "venMovConStockCr" ) {
     }

     public venMovConStockCrActionExchange(venMovConStockCrActionEnum.EnumvenMovConStockCrAction pAccion) : base(venMovConStockCrActionEnum.GetAccionvenMovConStockCrAction(pAccion)) {
     }

     public venMovConStockCrActionExchange(venMovConStockCrActionEnum.EnumvenMovConStockCrAction pAccion, VentasCommon.venMovConStockCrDS pdsParam) : base(venMovConStockCrActionEnum.GetAccionvenMovConStockCrAction(pAccion), pdsParam) {
     }

     public venMovConStockCrActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovConStockCrDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovConStockCrDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovConStockCrDS)mParam;
	        }
     }
  }
}
