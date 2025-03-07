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
    public class proMovCierreOrdenActionExchange : Framework.Core.Exchange{

        public Int32 Segmento_Id {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Parcial {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Parcial"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Parcial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Parcial = value;
               }
	          }
        public bool IsParcialNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsParcialNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String DescripcionCausas {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["DescripcionCausas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].DescripcionCausas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].DescripcionCausas = value;
               }
	          }
        public bool IsDescripcionCausasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsDescripcionCausasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreOrdenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proMovCierreOrdenDS );
     }
     public proMovCierreOrdenActionExchange() : base( "proMovCierreOrden" ) {
     }

     public proMovCierreOrdenActionExchange(proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction pAccion) : base(proMovCierreOrdenActionEnum.GetAccionproMovCierreOrdenAction(pAccion)) {
     }

     public proMovCierreOrdenActionExchange(proMovCierreOrdenActionEnum.EnumproMovCierreOrdenAction pAccion, ProduccionCommon.proMovCierreOrdenDS pdsParam) : base(proMovCierreOrdenActionEnum.GetAccionproMovCierreOrdenAction(pAccion), pdsParam) {
     }

     public proMovCierreOrdenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proMovCierreOrdenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proMovCierreOrdenDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proMovCierreOrdenDS)mParam;
	        }
     }
  }
}
