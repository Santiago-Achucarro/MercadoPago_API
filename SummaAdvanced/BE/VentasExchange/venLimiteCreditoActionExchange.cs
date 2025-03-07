using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venLimiteCreditoActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLimiteCreditoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLimiteCreditoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLimiteCreditoDS );
     }
     public venLimiteCreditoActionExchange() : base( "venLimiteCredito" ) {
     }

     public venLimiteCreditoActionExchange(venLimiteCreditoActionEnum.EnumvenLimiteCreditoAction pAccion) : base(venLimiteCreditoActionEnum.GetAccionvenLimiteCreditoAction(pAccion)) {
     }

     public venLimiteCreditoActionExchange(venLimiteCreditoActionEnum.EnumvenLimiteCreditoAction pAccion, VentasCommon.venLimiteCreditoDS pdsParam) : base(venLimiteCreditoActionEnum.GetAccionvenLimiteCreditoAction(pAccion), pdsParam) {
     }

     public venLimiteCreditoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLimiteCreditoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLimiteCreditoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLimiteCreditoDS)mParam;
	        }
     }
  }
}
