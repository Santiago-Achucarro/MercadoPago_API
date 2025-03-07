using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proOrdenActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public Decimal TamBatch {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["TamBatch"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].TamBatch;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].TamBatch = value;
               }
	          }
        public bool IsTamBatchNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsTamBatchNull();
             }
	        }
        public String Receta_Id {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionReceta {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["DescripcionReceta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionReceta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionReceta = value;
               }
	          }
        public bool IsDescripcionRecetaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsDescripcionRecetaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadIngresada {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["CantidadIngresada"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadIngresada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadIngresada = value;
               }
	          }
        public bool IsCantidadIngresadaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsCantidadIngresadaNull();
             }
	        }
        public DateTime FechaEmision {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["FechaEmision"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaEmision;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaEmision = value;
               }
	          }
        public bool IsFechaEmisionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsFechaEmisionNull();
             }
	        }
        public Decimal CantidadProgramada {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["CantidadProgramada"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadProgramada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadProgramada = value;
               }
	          }
        public bool IsCantidadProgramadaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsCantidadProgramadaNull();
             }
	        }
        public DateTime FechaNecesidad {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["FechaNecesidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaNecesidad;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaNecesidad = value;
               }
	          }
        public bool IsFechaNecesidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsFechaNecesidadNull();
             }
	        }
        public DateTime FechaProduccion {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["FechaProduccion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaProduccion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaProduccion = value;
               }
	          }
        public bool IsFechaProduccionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsFechaProduccionNull();
             }
	        }
        public DateTime FechaFin {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["FechaFin"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaFin;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].FechaFin = value;
               }
	          }
        public bool IsFechaFinNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsFechaFinNull();
             }
	        }
        public Decimal CantidadTerminada {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["CantidadTerminada"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadTerminada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CantidadTerminada = value;
               }
	          }
        public bool IsCantidadTerminadaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsCantidadTerminadaNull();
             }
	        }
        public Boolean CierreAutomatico {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["CierreAutomatico"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CierreAutomatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].CierreAutomatico = value;
               }
	          }
        public bool IsCierreAutomaticoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsCierreAutomaticoNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionMedida {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["DescripcionMedida"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionMedida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].DescripcionMedida = value;
               }
	          }
        public bool IsDescripcionMedidaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsDescripcionMedidaNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenDS );
     }
     public proOrdenActionExchange() : base( "proOrden" ) {
     }

     public proOrdenActionExchange(proOrdenActionEnum.EnumproOrdenAction pAccion) : base(proOrdenActionEnum.GetAccionproOrdenAction(pAccion)) {
     }

     public proOrdenActionExchange(proOrdenActionEnum.EnumproOrdenAction pAccion, ProduccionCommon.proOrdenDS pdsParam) : base(proOrdenActionEnum.GetAccionproOrdenAction(pAccion), pdsParam) {
     }

     public proOrdenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public proOrdenActionExchange(ProduccionCommon.proOrdenDS pDS) : base() {
     this.Action = "";
     this.mParam = new ProduccionCommon.proOrdenDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenDS)mParam;
	        }
     }
  }
}
