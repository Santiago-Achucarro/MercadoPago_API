using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genSegmentosValoresActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String TipoMov {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Sucursal {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean SinAutomatico {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["SinAutomatico"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].SinAutomatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].SinAutomatico = value;
               }
	          }
        public bool IsSinAutomaticoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSinAutomaticoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 AnioSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["AnioSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].AnioSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].AnioSueldos = value;
               }
	          }
        public bool IsAnioSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsAnioSueldosNull();
             }
	        }
        public Int32 MesSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["MesSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].MesSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].MesSueldos = value;
               }
	          }
        public bool IsMesSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsMesSueldosNull();
             }
	        }
        public Int32 QuinSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["QuinSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].QuinSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].QuinSueldos = value;
               }
	          }
        public bool IsQuinSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsQuinSueldosNull();
             }
	        }
        public Int32 DecenaSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["DecenaSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].DecenaSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].DecenaSueldos = value;
               }
	          }
        public bool IsDecenaSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsDecenaSueldosNull();
             }
	        }
        public Int32 SemanaSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["SemanaSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].SemanaSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].SemanaSueldos = value;
               }
	          }
        public bool IsSemanaSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsSemanaSueldosNull();
             }
	        }
        public Int32 VezSueldos {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["VezSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].VezSueldos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].VezSueldos = value;
               }
	          }
        public bool IsVezSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsVezSueldosNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSegmentosValoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSegmentosValoresDS );
     }
     public genSegmentosValoresActionExchange() : base( "genSegmentosValores" ) {
     }

     public genSegmentosValoresActionExchange(genSegmentosValoresActionEnum.EnumgenSegmentosValoresAction pAccion) : base(genSegmentosValoresActionEnum.GetAcciongenSegmentosValoresAction(pAccion)) {
     }

     public genSegmentosValoresActionExchange(genSegmentosValoresActionEnum.EnumgenSegmentosValoresAction pAccion, GeneralesCommon.genSegmentosValoresDS pdsParam) : base(genSegmentosValoresActionEnum.GetAcciongenSegmentosValoresAction(pAccion), pdsParam) {
     }

     public genSegmentosValoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSegmentosValoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSegmentosValoresDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSegmentosValoresDS)mParam;
	        }
     }
  }
}
