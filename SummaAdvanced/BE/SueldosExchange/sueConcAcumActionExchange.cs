using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueConcAcumActionExchange : Framework.Core.Exchange{

        public Int32 sueConcAcum {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["sueConcAcum"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].sueConcAcum;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].sueConcAcum = value;
               }
	          }
        public bool IssueConcAcumNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IssueConcAcumNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public String DescripcionConceptos {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["DescripcionConceptos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionConceptos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionConceptos = value;
               }
	          }
        public bool IsDescripcionConceptosNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsDescripcionConceptosNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal MontoTope {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["MontoTope"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].MontoTope;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].MontoTope = value;
               }
	          }
        public bool IsMontoTopeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsMontoTopeNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public Decimal Acumulado {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Acumulado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Acumulado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Acumulado = value;
               }
	          }
        public bool IsAcumuladoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsAcumuladoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConcAcumDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConcAcumDS );
     }
     public sueConcAcumActionExchange() : base( "sueConcAcum" ) {
     }

     public sueConcAcumActionExchange(sueConcAcumActionEnum.EnumsueConcAcumAction pAccion) : base(sueConcAcumActionEnum.GetAccionsueConcAcumAction(pAccion)) {
     }

     public sueConcAcumActionExchange(sueConcAcumActionEnum.EnumsueConcAcumAction pAccion, SueldosCommon.sueConcAcumDS pdsParam) : base(sueConcAcumActionEnum.GetAccionsueConcAcumAction(pAccion), pdsParam) {
     }

     public sueConcAcumActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConcAcumDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConcAcumDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConcAcumDS)mParam;
	        }
     }
  }
}
