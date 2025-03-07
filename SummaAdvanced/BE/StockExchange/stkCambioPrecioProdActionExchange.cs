using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkCambioPrecioProdActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Decimal CantidadAjuste {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["CantidadAjuste"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].CantidadAjuste;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].CantidadAjuste = value;
               }
	          }
        public bool IsCantidadAjusteNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsCantidadAjusteNull();
             }
	        }
        public Decimal MontoAjuste {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["MontoAjuste"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].MontoAjuste;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].MontoAjuste = value;
               }
	          }
        public bool IsMontoAjusteNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsMontoAjusteNull();
             }
	        }
        public Decimal PrecioMonOriginal {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["PrecioMonOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PrecioMonOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PrecioMonOriginal = value;
               }
	          }
        public bool IsPrecioMonOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPrecioMonOriginalNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Decimal MontoAjustado {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["MontoAjustado"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].MontoAjustado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].MontoAjustado = value;
               }
	          }
        public bool IsMontoAjustadoNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsMontoAjustadoNull();
             }
	        }
        public Decimal PPP_Actual {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["PPP_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PPP_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PPP_Actual = value;
               }
	          }
        public bool IsPPP_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPPP_ActualNull();
             }
	        }
        public Decimal PPP_Anterior {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["PPP_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PPP_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PPP_Anterior = value;
               }
	          }
        public bool IsPPP_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPPP_AnteriorNull();
             }
	        }
        public Decimal PUC_Actual {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["PUC_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PUC_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PUC_Actual = value;
               }
	          }
        public bool IsPUC_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPUC_ActualNull();
             }
	        }
        public Decimal PUC_Anterior {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["PUC_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PUC_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].PUC_Anterior = value;
               }
	          }
        public bool IsPUC_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsPUC_AnteriorNull();
             }
	        }
        public Decimal STD_Actual {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["STD_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].STD_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].STD_Actual = value;
               }
	          }
        public bool IsSTD_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsSTD_ActualNull();
             }
	        }
        public Decimal STD_Anterior {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["STD_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].STD_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].STD_Anterior = value;
               }
	          }
        public bool IsSTD_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsSTD_AnteriorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public Boolean EstoyEnCierre {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["EstoyEnCierre"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].EstoyEnCierre;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].EstoyEnCierre = value;
               }
	          }
        public bool IsEstoyEnCierreNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsEstoyEnCierreNull();
             }
	        }
        public DateTime FechaCierre {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["FechaCierre"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].FechaCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].FechaCierre = value;
               }
	          }
        public bool IsFechaCierreNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsFechaCierreNull();
             }
	        }
        public String Sucursal {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Decimal Stock {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Stock"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Stock;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Stock = value;
               }
	          }
        public bool IsStockNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsStockNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkCambioPrecioProdDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCambioPrecioProdDS );
     }
     public stkCambioPrecioProdActionExchange() : base( "stkCambioPrecioProd" ) {
     }

     public stkCambioPrecioProdActionExchange(stkCambioPrecioProdActionEnum.EnumstkCambioPrecioProdAction pAccion) : base(stkCambioPrecioProdActionEnum.GetAccionstkCambioPrecioProdAction(pAccion)) {
     }

     public stkCambioPrecioProdActionExchange(stkCambioPrecioProdActionEnum.EnumstkCambioPrecioProdAction pAccion, StockCommon.stkCambioPrecioProdDS pdsParam) : base(stkCambioPrecioProdActionEnum.GetAccionstkCambioPrecioProdAction(pAccion), pdsParam) {
     }

     public stkCambioPrecioProdActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCambioPrecioProdDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCambioPrecioProdDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCambioPrecioProdDS)mParam;
	        }
     }
  }
}
