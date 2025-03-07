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
    public class venClientesCtasPlantillaActionExchange : Framework.Core.Exchange{

        public String Plantilla_Id {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["Plantilla_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Plantilla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Plantilla_Id = value;
               }
	          }
        public bool IsPlantilla_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsPlantilla_IdNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String CuentaDxVtas {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["CuentaDxVtas"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CuentaDxVtas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CuentaDxVtas = value;
               }
	          }
        public bool IsCuentaDxVtasNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsCuentaDxVtasNull();
             }
	        }
        public String DescripcionCuentaDxVtas {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["DescripcionCuentaDxVtas"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCuentaDxVtas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCuentaDxVtas = value;
               }
	          }
        public bool IsDescripcionCuentaDxVtasNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsDescripcionCuentaDxVtasNull();
             }
	        }
        public String CtaFactAnticipo {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["CtaFactAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CtaFactAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CtaFactAnticipo = value;
               }
	          }
        public bool IsCtaFactAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsCtaFactAnticipoNull();
             }
	        }
        public String DescripcionCtaFactAnticipo {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["DescripcionCtaFactAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCtaFactAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCtaFactAnticipo = value;
               }
	          }
        public bool IsDescripcionCtaFactAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsDescripcionCtaFactAnticipoNull();
             }
	        }
        public String CtaAnticipo {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["CtaAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CtaAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].CtaAnticipo = value;
               }
	          }
        public bool IsCtaAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsCtaAnticipoNull();
             }
	        }
        public String DescripcionCtaAnticipo {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["DescripcionCtaAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCtaAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].DescripcionCtaAnticipo = value;
               }
	          }
        public bool IsDescripcionCtaAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsDescripcionCtaAnticipoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesCtasPlantillaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClientesCtasPlantillaDS );
     }
     public venClientesCtasPlantillaActionExchange() : base( "venClientesCtasPlantilla" ) {
     }

     public venClientesCtasPlantillaActionExchange(venClientesCtasPlantillaActionEnum.EnumvenClientesCtasPlantillaAction pAccion) : base(venClientesCtasPlantillaActionEnum.GetAccionvenClientesCtasPlantillaAction(pAccion)) {
     }

     public venClientesCtasPlantillaActionExchange(venClientesCtasPlantillaActionEnum.EnumvenClientesCtasPlantillaAction pAccion, VentasCommon.venClientesCtasPlantillaDS pdsParam) : base(venClientesCtasPlantillaActionEnum.GetAccionvenClientesCtasPlantillaAction(pAccion), pdsParam) {
     }

     public venClientesCtasPlantillaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClientesCtasPlantillaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClientesCtasPlantillaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClientesCtasPlantillaDS)mParam;
	        }
     }
  }
}
