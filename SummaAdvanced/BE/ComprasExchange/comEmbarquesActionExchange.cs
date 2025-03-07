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
    public class comEmbarquesActionExchange : Framework.Core.Exchange{

        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String TipoTransporte {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["TipoTransporte"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].TipoTransporte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].TipoTransporte = value;
               }
	          }
        public bool IsTipoTransporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsTipoTransporteNull();
             }
	        }
        public String NroOrdenExterior {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["NroOrdenExterior"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].NroOrdenExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].NroOrdenExterior = value;
               }
	          }
        public bool IsNroOrdenExteriorNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsNroOrdenExteriorNull();
             }
	        }
        public DateTime FechaEmbarque {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["FechaEmbarque"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].FechaEmbarque;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].FechaEmbarque = value;
               }
	          }
        public bool IsFechaEmbarqueNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsFechaEmbarqueNull();
             }
	        }
        public DateTime FechaArribo {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["FechaArribo"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].FechaArribo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].FechaArribo = value;
               }
	          }
        public bool IsFechaArriboNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsFechaArriboNull();
             }
	        }
        public Decimal PesoTotal {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["PesoTotal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].PesoTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].PesoTotal = value;
               }
	          }
        public bool IsPesoTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsPesoTotalNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionEmbEstado {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["DescripcionEmbEstado"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].DescripcionEmbEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].DescripcionEmbEstado = value;
               }
	          }
        public bool IsDescripcionEmbEstadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsDescripcionEmbEstadoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Decimal Total {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEmbarquesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbarquesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEmbarquesDS );
     }
     public comEmbarquesActionExchange() : base( "comEmbarques" ) {
     }

     public comEmbarquesActionExchange(comEmbarquesActionEnum.EnumcomEmbarquesAction pAccion) : base(comEmbarquesActionEnum.GetAccioncomEmbarquesAction(pAccion)) {
     }

     public comEmbarquesActionExchange(comEmbarquesActionEnum.EnumcomEmbarquesAction pAccion, ComprasCommon.comEmbarquesDS pdsParam) : base(comEmbarquesActionEnum.GetAccioncomEmbarquesAction(pAccion), pdsParam) {
     }

     public comEmbarquesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEmbarquesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEmbarquesDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEmbarquesDS)mParam;
	        }
     }
  }
}
