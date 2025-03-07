using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impLiquidacionActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuesto {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["DescripcionImpuesto"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].DescripcionImpuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].DescripcionImpuesto = value;
               }
	          }
        public bool IsDescripcionImpuestoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsDescripcionImpuestoNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Decimal TotalaPagar {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["TotalaPagar"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].TotalaPagar;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].TotalaPagar = value;
               }
	          }
        public bool IsTotalaPagarNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsTotalaPagarNull();
             }
	        }
        public Boolean SePaga {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["SePaga"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].SePaga;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].SePaga = value;
               }
	          }
        public bool IsSePagaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsSePagaNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLiquidacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impLiquidacionDS );
     }
     public impLiquidacionActionExchange() : base( "impLiquidacion" ) {
     }

     public impLiquidacionActionExchange(impLiquidacionActionEnum.EnumimpLiquidacionAction pAccion) : base(impLiquidacionActionEnum.GetAccionimpLiquidacionAction(pAccion)) {
     }

     public impLiquidacionActionExchange(impLiquidacionActionEnum.EnumimpLiquidacionAction pAccion, ImpuestosCommon.impLiquidacionDS pdsParam) : base(impLiquidacionActionEnum.GetAccionimpLiquidacionAction(pAccion), pdsParam) {
     }

     public impLiquidacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impLiquidacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impLiquidacionDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impLiquidacionDS)mParam;
	        }
     }
  }
}
