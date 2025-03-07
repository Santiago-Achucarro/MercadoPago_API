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
    public class stkEntradasOcActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean DistribuyeContrapartida {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["DistribuyeContrapartida"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DistribuyeContrapartida;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DistribuyeContrapartida = value;
               }
	          }
        public bool IsDistribuyeContrapartidaNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsDistribuyeContrapartidaNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Formulario {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Formulario"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Formulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Formulario = value;
               }
	          }
        public bool IsFormularioNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsFormularioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public Boolean ModificaCosto {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["ModificaCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].ModificaCosto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].ModificaCosto = value;
               }
	          }
        public bool IsModificaCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsModificaCostoNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public String Tipomov {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String Sucursal {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkEntradasOcDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEntradasOcDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkEntradasOcDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkEntradasOcDS );
     }
     public stkEntradasOcActionExchange() : base( "stkEntradasOc" ) {
     }

     public stkEntradasOcActionExchange(stkEntradasOcActionEnum.EnumstkEntradasOcAction pAccion) : base(stkEntradasOcActionEnum.GetAccionstkEntradasOcAction(pAccion)) {
     }

     public stkEntradasOcActionExchange(stkEntradasOcActionEnum.EnumstkEntradasOcAction pAccion, StockCommon.stkEntradasOcDS pdsParam) : base(stkEntradasOcActionEnum.GetAccionstkEntradasOcAction(pAccion), pdsParam) {
     }

     public stkEntradasOcActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkEntradasOcDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkEntradasOcDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkEntradasOcDS)mParam;
	        }
     }
  }
}
