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
    public class stkMoviCuerpoRevaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Decimal PUC_Actual {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["PUC_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PUC_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PUC_Actual = value;
               }
	          }
        public bool IsPUC_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsPUC_ActualNull();
             }
	        }
        public Decimal PUC_Anterior {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["PUC_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PUC_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PUC_Anterior = value;
               }
	          }
        public bool IsPUC_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsPUC_AnteriorNull();
             }
	        }
        public Decimal PPP_Actual {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["PPP_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PPP_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PPP_Actual = value;
               }
	          }
        public bool IsPPP_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsPPP_ActualNull();
             }
	        }
        public Decimal PPP_Anterior {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["PPP_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PPP_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].PPP_Anterior = value;
               }
	          }
        public bool IsPPP_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsPPP_AnteriorNull();
             }
	        }
        public Decimal STD_Actual {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["STD_Actual"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].STD_Actual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].STD_Actual = value;
               }
	          }
        public bool IsSTD_ActualNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsSTD_ActualNull();
             }
	        }
        public Decimal STD_Anterior {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["STD_Anterior"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].STD_Anterior;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].STD_Anterior = value;
               }
	          }
        public bool IsSTD_AnteriorNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsSTD_AnteriorNull();
             }
	        }
        public Decimal ImporteAjuste {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["ImporteAjuste"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].ImporteAjuste;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].ImporteAjuste = value;
               }
	          }
        public bool IsImporteAjusteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsImporteAjusteNull();
             }
	        }
        public Decimal ImporteAjusteCosto {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["ImporteAjusteCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].ImporteAjusteCosto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].ImporteAjusteCosto = value;
               }
	          }
        public bool IsImporteAjusteCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsImporteAjusteCostoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String CtaCompras {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["CtaCompras"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].CtaCompras;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].CtaCompras = value;
               }
	          }
        public bool IsCtaComprasNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsCtaComprasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCuerpoRevaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviCuerpoRevaDS );
     }
     public stkMoviCuerpoRevaActionExchange() : base( "stkMoviCuerpoReva" ) {
     }

     public stkMoviCuerpoRevaActionExchange(stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction pAccion) : base(stkMoviCuerpoRevaActionEnum.GetAccionstkMoviCuerpoRevaAction(pAccion)) {
     }

     public stkMoviCuerpoRevaActionExchange(stkMoviCuerpoRevaActionEnum.EnumstkMoviCuerpoRevaAction pAccion, StockCommon.stkMoviCuerpoRevaDS pdsParam) : base(stkMoviCuerpoRevaActionEnum.GetAccionstkMoviCuerpoRevaAction(pAccion), pdsParam) {
     }

     public stkMoviCuerpoRevaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviCuerpoRevaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviCuerpoRevaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviCuerpoRevaDS)mParam;
	        }
     }
  }
}
