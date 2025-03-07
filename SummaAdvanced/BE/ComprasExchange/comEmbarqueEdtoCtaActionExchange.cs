using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comEmbarqueEdtoCtaActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Boolean Cerrando {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Cerrando"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Cerrando;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Cerrando = value;
               }
	          }
        public bool IsCerrandoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsCerrandoNull();
             }
	        }
        public Int64 stkMoviCabeReva {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["stkMoviCabeReva"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].stkMoviCabeReva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].stkMoviCabeReva = value;
               }
	          }
        public bool IsstkMoviCabeRevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsstkMoviCabeRevaNull();
             }
	        }
        public DateTime FechaCierreStock {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["FechaCierreStock"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaCierreStock;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaCierreStock = value;
               }
	          }
        public bool IsFechaCierreStockNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsFechaCierreStockNull();
             }
	        }
        public DateTime FechaCierreEmb {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["FechaCierreEmb"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaCierreEmb;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaCierreEmb = value;
               }
	          }
        public bool IsFechaCierreEmbNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsFechaCierreEmbNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarqueEdtoCtaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEmbarqueEdtoCtaDS );
     }
     public comEmbarqueEdtoCtaActionExchange() : base( "comEmbarqueEdtoCta" ) {
     }

     public comEmbarqueEdtoCtaActionExchange(comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction pAccion) : base(comEmbarqueEdtoCtaActionEnum.GetAccioncomEmbarqueEdtoCtaAction(pAccion)) {
     }

     public comEmbarqueEdtoCtaActionExchange(comEmbarqueEdtoCtaActionEnum.EnumcomEmbarqueEdtoCtaAction pAccion, ComprasCommon.comEmbarqueEdtoCtaDS pdsParam) : base(comEmbarqueEdtoCtaActionEnum.GetAccioncomEmbarqueEdtoCtaAction(pAccion), pdsParam) {
     }

     public comEmbarqueEdtoCtaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEmbarqueEdtoCtaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEmbarqueEdtoCtaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEmbarqueEdtoCtaDS)mParam;
	        }
     }
  }
}
