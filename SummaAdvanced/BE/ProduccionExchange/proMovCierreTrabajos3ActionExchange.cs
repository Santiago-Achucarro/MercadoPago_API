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
    public class proMovCierreTrabajos3ActionExchange : Framework.Core.Exchange{

        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Trabajo3_Id {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Trabajo3_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Trabajo3_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Trabajo3_Id = value;
               }
	          }
        public bool IsTrabajo3_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsTrabajo3_IdNull();
             }
	        }
        public String DescripcionTrabajo3 {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["DescripcionTrabajo3"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].DescripcionTrabajo3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].DescripcionTrabajo3 = value;
               }
	          }
        public bool IsDescripcionTrabajo3Null {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsDescripcionTrabajo3Null();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proMovCierreTrabajos3DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proMovCierreTrabajos3DS );
     }
     public proMovCierreTrabajos3ActionExchange() : base( "proMovCierreTrabajos3" ) {
     }

     public proMovCierreTrabajos3ActionExchange(proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action pAccion) : base(proMovCierreTrabajos3ActionEnum.GetAccionproMovCierreTrabajos3Action(pAccion)) {
     }

     public proMovCierreTrabajos3ActionExchange(proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action pAccion, ProduccionCommon.proMovCierreTrabajos3DS pdsParam) : base(proMovCierreTrabajos3ActionEnum.GetAccionproMovCierreTrabajos3Action(pAccion), pdsParam) {
     }

     public proMovCierreTrabajos3ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proMovCierreTrabajos3DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proMovCierreTrabajos3DS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proMovCierreTrabajos3DS)mParam;
	        }
     }
  }
}
